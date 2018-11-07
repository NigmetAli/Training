using System;

namespace MYARCH.UTILITIES.StringOperations
{
    public static class PassManager
    {
        public static string Base64Encrypt(string data)
        {
            try
            {
                byte[] dataByteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(data);
                string encryptedData = System.Convert.ToBase64String(dataByteArray);
                return encryptedData;
            }
            catch (Exception)
            {
                return data;
            }
        }

        public static string Base64Decrypt(string decryptData)
        {
            try
            {
                byte[] decryptDataArray = System.Convert.FromBase64String(decryptData);
                string originalData = System.Text.ASCIIEncoding.ASCII.GetString(decryptDataArray);
                return originalData;
            }
            catch (Exception)
            {
                return decryptData;
            }
        }
    }
}
