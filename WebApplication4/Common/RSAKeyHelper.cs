using System.Security.Cryptography;


namespace ASPNETCoreAngularJWT
{
     public class RSAKeyHelper
    {
        public static RSAParameters GenerateKey()
        {
            using (var key = new RSACryptoServiceProvider(2048))
            {
                var esd = key.ExportParameters(true);
                return esd;
            }
        }
    }
}