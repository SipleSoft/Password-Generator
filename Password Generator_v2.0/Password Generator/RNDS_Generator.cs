using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Password_Generator
{
    //----------- Random String Generator Class -----------
    // RNDS_Generator(<List>Charset, ref <int>Length)
    // <int>Length - Password lenght
    // <List>Charset - List for charset generator to use:
    // - string markers:
    // ch_09 -> Charset Numbers 0-9
    // ch_az -> Charset Small Caps a-z
    // ch_az_trm -> Charset Small Caps a-z Trimmed [l,o]
    // ch_AZ -> Charset Big Caps A-Z
    // ch_AZ_trm -> Charset Big Caps A-Z Trimmed [I,O]
    // ch_symb_full -> Charset Special Characters Full Set [!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~]
    // ch_symb_bsc -> Charset Special Characters Basic Set [!#$%&()*+-.:;<=>?@[]_{}]
    // ch_symb_17 -> Charset Special Characters Set 17 [!#$%&()*+-.:<=>?_]
    // ch_symb_8 -> Charset Special Characters Set 8 [!#$%&*+?]
    //
    // <string>GenerateString(<int>Length)
    // - Returns Password with defined Length '<int>Length'
    // <string>GenerateString()
    // - Returns Password with Length defined in Constructor   
    //----------------------------------------------------------------------

    class RNDS_Generator
    {
        public RNDS_Generator(List<string> chSet, int Lenght)
        { InitializeVariables(chSet, Lenght); }

        private List<int[]> Matrix;
        private List<string> UserCharset;
        private Int32 PassLen;

        public string GenerateString()
        { return GenerateString(PassLen); }

        public string GenerateString(int Length)
        {
            if (Matrix.Count == 0) return String.Empty;
            // Initialize arrayas
            int chrSetDepth = Matrix.Count;
            char[] charArray = new char[Length];
            byte[] byteArray = new byte[Length * 16];
            // Password construction
            for (int i = 0; i < Length; i++)
            {
                Array.Clear(byteArray, 0, byteArray.Length);
                new RNGCryptoServiceProvider().GetBytes(byteArray);
                UInt32 arSel = BitConverter.ToUInt32(byteArray, 0);
                UInt32 chSel = BitConverter.ToUInt32(byteArray, 7);
                int[] buffer = Matrix[Math.Abs((int)arSel % chrSetDepth)];
                charArray[i] = Convert.ToChar(buffer[chSel % buffer.Length]);
            }
            return new string(charArray);
        }

        private void BuildMatrix()
        {
            if (UserCharset.Any(str => str.Contains("ch_09"))) { Matrix.Add(CHAR.ch_09); }
            if (UserCharset.Any(str => str.Contains("ch_az"))) { Matrix.Add(CHAR.ch_az); }
            if (UserCharset.Any(str => str.Contains("ch_az_trm"))) { Matrix.Add(CHAR.ch_az_trm); }
            if (UserCharset.Any(str => str.Contains("ch_AZ"))) { Matrix.Add(CHAR.ch_AZ); }
            if (UserCharset.Any(str => str.Contains("ch_AZ_trm"))) { Matrix.Add(CHAR.ch_AZ_trm); }
            if (UserCharset.Any(str => str.Contains("ch_symb_full"))) { Matrix.Add(CHAR.ch_symb_full); }
            if (UserCharset.Any(str => str.Contains("ch_symb_bsc"))) { Matrix.Add(CHAR.ch_symb_bsc); }
            if (UserCharset.Any(str => str.Contains("ch_symb_17"))) { Matrix.Add(CHAR.ch_symb_17); }
            if (UserCharset.Any(str => str.Contains("ch_symb_8"))) { Matrix.Add(CHAR.ch_symb_8); }
        }

        private void InitializeVariables(List<string> chSet, int Lenght)
        {
            Matrix = new List<int[]>();
            UserCharset = chSet;
            PassLen = Lenght;
            BuildMatrix();
        }

        private static class CHAR
        {
            public static int[] ch_09 = { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 }; // Numbers 0-9
            public static int[] ch_az = { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 }; // Small letters a-z
            public static int[] ch_az_trm = { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122 }; // Trimmed small letters a-z [l,o]
            public static int[] ch_AZ = { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 }; // Big letters A-Z
            public static int[] ch_AZ_trm = { 65, 66, 67, 68, 69, 70, 71, 72, 74, 75, 76, 77, 78, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 }; // Trimmed big letters A-Z [I,O]
            public static int[] ch_symb_full = { 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 58, 59, 60, 61, 62, 63, 64, 91, 92, 93, 94, 95, 96, 123, 124, 125, 126 }; // Special characters full set [!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~]
            public static int[] ch_symb_bsc = { 33, 35, 36, 37, 38, 40, 41, 42, 43, 45, 46, 58, 59, 60, 61, 62, 63, 64, 91, 93, 95, 123, 125 }; // Special characters basic set [!#$%&()*+-.:;<=>?@[]_{}]
            public static int[] ch_symb_17 = { 33, 35, 36, 37, 38, 40, 41, 42, 43, 45, 46, 58, 60, 61, 62, 63, 95 }; // Special characters set 17 [!#$%&()*+-.:<=>?_]
            public static int[] ch_symb_8 = { 33, 35, 36, 37, 38, 42, 43, 63 }; // Special characters set 8 [!#$%&*+?]
        }
    }
}