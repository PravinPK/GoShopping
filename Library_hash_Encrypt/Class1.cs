using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Library_hash_Encrypt
{
    public class Class1
    {

    }
    public class Hashing
    {
        public static String HashPassword(String password)
        {
            String salt = "SecretCode";
            UnicodeEncoding Uce = new UnicodeEncoding();
            byte[] passInByte = Uce.GetBytes(password);
            using (var sha = new SHA512CryptoServiceProvider())
            {
                var hashedString = sha.ComputeHash(Encoding.Default.GetBytes(password + salt));
                return Convert.ToBase64String(hashedString);
            }

        }

    }
    public class Encryption_and_Decryption
    {
        


        public static string Encrypt(string plainString)
        { // encryption using DES 
            byte[] seed = ASCIIEncoding.ASCII.GetBytes("dhy45423");
            if (String.IsNullOrEmpty(plainString))
            {
                throw new ArgumentNullException("The input cannot be empty or null!");
            }
            SymmetricAlgorithm saProvider = DES.Create();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, saProvider.CreateEncryptor(seed, seed), CryptoStreamMode.Write);
            StreamWriter sWriter = new StreamWriter(cStream);
            sWriter.Write(plainString);
            sWriter.Flush(); // Buffer flush is necessary when switching writing modes
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.GetBuffer(), 0, (int)mStream.Length);
        }

        public static string Decrypt(string encryptedString) { // decryption using DES 
            byte[] seed = ASCIIEncoding.ASCII.GetBytes("dhy45423");
            if (String.IsNullOrEmpty(encryptedString)) {
                throw new ArgumentNullException("The string cannot be empty or null!");
            }
            SymmetricAlgorithm saProvider = DES.Create(); 
            MemoryStream memStream = new MemoryStream
                    (Convert.FromBase64String(encryptedString));
            CryptoStream cStream = new CryptoStream(memStream,
                saProvider.CreateDecryptor(seed, seed), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cStream);
            return reader.ReadLine();
}   }   }
