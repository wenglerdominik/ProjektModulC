using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

namespace Wifi.Auto.Data
{
    [Serializable()]
    
    public class SecuredAutoFile
    {
        #region Properties

        [XmlIgnore()]
        public string Owner { get; set; }
        [XmlIgnore()]
        public string MasterKey { get; set; }

        [XmlElement(ElementName = "Owner")]
        public string OwnerEncrypted { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime CreationDate { get; set; }

        public List<KfzData> FahrzeugInfos { get; set; } = new List<KfzData>();

        #endregion

        public static SecuredAutoFile Read(string fileName, string password)
        {
            StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(SecuredAutoFile));
            SecuredAutoFile securedAutoFile = (SecuredAutoFile)serializer.Deserialize(reader);
            reader.Close();

            securedAutoFile.Owner = securedAutoFile.Decrypt(securedAutoFile.OwnerEncrypted, password);
            
            return securedAutoFile;
        }


        public void Save(string fileName, string password)
        {
            this.OwnerEncrypted = Encrypt(this.Owner, password);
						
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(SecuredAutoFile));
            serializer.Serialize(writer, this);
            writer.Close();
        }



        public string Encrypt(string plainText, string password)
        {
            string result = string.Empty;
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            using (Aes aes = Aes.Create())
            {
                //aes.Mode = CipherMode.ECB;
                //aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.KeySize = 256;
                aes.BlockSize = 128;
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(key, aes.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        result = $"{Convert.ToBase64String(msEncrypt.ToArray())}{Convert.ToBase64String(aes.IV)}";
                    }
                }
            }

            return result;
        }

        public string Decrypt(string cipherText, string password)
        {
            string result = string.Empty;
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            using (Aes aes = new AesManaged())
            {
                //aes.Mode = CipherMode.ECB;
                //aes.Padding = PaddingMode.Zeros;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.KeySize = 256;
                aes.BlockSize = 128;
                string iv = cipherText.Substring(cipherText.Length - 24);
                string tmp = cipherText.Substring(0, cipherText.Length - 24);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aes.CreateDecryptor(key, Convert.FromBase64String(iv));
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(tmp)))
                {
                    msDecrypt.Position = 0;
                    byte[] buf = null;
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            result = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return result;
        }

    }
}
