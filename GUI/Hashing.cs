﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Hashing
    {

        public Hashing()
        {

        }

        public string GenSalt(String password, String salt)
        {
            String hashedPassword = GenerateHash(password, salt);

            return hashedPassword; 
        }

        public String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private String GenerateHash(String Input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Input + salt);
            System.Security.Cryptography.SHA256Managed hashString = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = hashString.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

        private static String ByteArrayToHexString(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);

            foreach(byte b in bytes)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }
    }
}
