using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository.Tools
{
    public class ConvertTool
    {
        private static string Hash = "ASDLaminatSoftware2024MK";

        public static string MD5Convert(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(text));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

        public static string Base64Encode(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] keys = MD5.HashData(Encoding.UTF8.GetBytes(Hash));

            using (var tripleDes = TripleDES.Create())
            {
                tripleDes.Key = keys;
                tripleDes.Mode = CipherMode.ECB;
                tripleDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripleDes.CreateEncryptor();
                byte[] output = transform.TransformFinalBlock(data, 0, data.Length);
                return Convert.ToBase64String(output, 0, output.Length);
            }
        }

        public static string Base64Decode(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            byte[] keys = MD5.HashData(Encoding.UTF8.GetBytes(Hash));

            using (var tripleDes = TripleDES.Create())
            {
                tripleDes.Key = keys;
                tripleDes.Mode = CipherMode.ECB;
                tripleDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripleDes.CreateDecryptor();
                byte[] output = transform.TransformFinalBlock(data, 0, data.Length);
                return Encoding.UTF8.GetString(output);
            }
        }

        public static byte[] FileToBase64(IFormFile file)
        {
            byte[] fileContent = null;
            if (file?.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
            }
            return fileContent;
        }

        public static string RemoveSpecialCharacters(string input)
        {
            var trimInput = input.Trim();
            var clearInput = Regex.Replace(trimInput, "<.*?>", String.Empty);
            Regex reg = new Regex("[^a-z0-9.ı]+", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return reg.Replace(clearInput, String.Empty);
        }

        //public static Stream CompressImage(Stream fileStream)
        //{
        //    var memoryStream = new MemoryStream();
        //    fileStream.CopyTo(memoryStream);

        //    memoryStream.Position = 0;

        //    var optimizer = new ImageOptimizer();
        //    optimizer.OptimalCompression = true;
        //    optimizer.Compress(memoryStream);

        //    return memoryStream;
        //}
    }
}
