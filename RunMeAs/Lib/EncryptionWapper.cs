using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Utility.Serializer
{
    internal class EncryptionWapper
    {
        internal static string Encrypt(string secureUserData, string hashing = null)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(secureUserData);
            byte[] resultArray;

            if (hashing != null)
            {

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashing));
                hashmd5.Clear();

            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(string.Empty);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = tdes.CreateEncryptor();

            resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        internal static string Decrypt(string cipherString, string hashing = null)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);
            byte[] resultArray;

            if (hashing != null)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashing));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(string.Empty);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };


            ICryptoTransform cTransform = tdes.CreateDecryptor();
            resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);


            tdes.Clear();


            return UTF8Encoding.UTF8.GetString(resultArray);

        }
    }
}
