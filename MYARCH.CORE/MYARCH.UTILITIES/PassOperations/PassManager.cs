using System;
using System.Text;

namespace MYARCH.UTILITIES.StringOperations
{
    public static class PassManager
    {
        public static string Base64Encrypt(string data)
        {
            try
            {
                byte[] dataByteArray = Encoding.ASCII.GetBytes(data);
                string encryptedData = Convert.ToBase64String(dataByteArray);
                return encryptedData;
            }
            catch (Exception)
            {
                return data
            }
        }

        public static string Base64Decrypt(string decryptData)
        {
            try
            {
                byte[] decryptDataArray = System.Convert.FromBase64String(decryptData);
                string originalData = Encoding.ASCII.GetString(decryptDataArray);
                return originalData;
            }
            catch (Exception)
            {
                return decryptData;
            }
        }
    }
}
