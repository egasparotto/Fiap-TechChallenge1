using System.Security.Cryptography;

namespace FiapBlog.Domain.Services.Cryptography
{
    public class PasswordCryptography
    {
        public static string Encrypt(string text)
        {
            if(text == null)
            {
                return null;
            }

            byte[] salt = new byte[16];
            RandomNumberGenerator.Create().GetNonZeroBytes(salt);
            var senha = new Rfc2898DeriveBytes(text, salt, 1000, HashAlgorithmName.SHA1);
            byte[] hash = senha.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool Decrypt(string text, string hash)
        {
            try
            {
                byte[] hashBytes = Convert.FromBase64String(hash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var senha = new Rfc2898DeriveBytes(text, salt, 1000, HashAlgorithmName.SHA1);
                byte[] hashSenha = senha.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hashSenha[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
