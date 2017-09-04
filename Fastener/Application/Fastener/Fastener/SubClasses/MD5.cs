using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

//The following version is taken from the Microsoft MSDN website for .NET Framework 3.5.
//Link: http://msdn.microsoft.com/it-it/library/system.security.cryptography.md5cryptoserviceprovider(v=vs.90).aspx

//There's also a version for .NET Framework 2.0, which is available at http://msdn.microsoft.com/it-it/library/system.security.cryptography.md5cryptoserviceprovider(v=vs.80).aspx
//and a version for the .NET Framework 4.0, which is available at http://msdn.microsoft.com/it-it/library/system.security.cryptography.md5cryptoserviceprovider(v=vs.100).aspx
//Version for 4.0 is NOT implemented here as Spartan UK is still using 3.5.

namespace Fastener
{
    /// <summary>
    /// MD5 class from MSDN website for framework 3.5
    /// </summary>
    static class MD5
    {
        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        public static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool verifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
