using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HotelGestion
{
    public static class CommonMethods
    {
        public static string Key = "adef@@kfxcbv";

        public static string ConvertToEncrypt(string password)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(password);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;

        }
        public static string ConvertToDescrypt(string base64EncodeDataa)
        {
            byte[] b;
            string decrypted;
            try
            {
                b = Convert.FromBase64String(base64EncodeDataa);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                decrypted = "";
            }
            return decrypted;
        }
    }
}