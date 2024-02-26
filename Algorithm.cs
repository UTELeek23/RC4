using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4
{
    public class Algorithm
    {

        int[] S = new int[256];
        int[] T = new int[256];
        int[] k = new int[256];
        public void Setup(int[] key)
        {

            for (int i = 0; i < 256; ++i)
            {
                S[i] = i;
                T[i] = key[i % key.Length];
            }

        }  
        public void KSA()
        {
            int j = 0;
            for(int i = 0; i < 256; ++i)
            {
                j = (j + S[i] + T[i]) % 256;
                Swap(S, i, j);

            }
        }
        public void PRGA(int[] PT)
        {
            int i = 0;
            int j = 0;
            int a = 0;
            for(i = 0; i <= PT.Length; ++i)
            {
                i = (i + 1) % 256;
                j = (j + S[i]) % 256;
                Swap(S, i, j);
                k[a++] = S[(S[i] + S[j]) % 256];
            }
        }
        public int[] Encrypt(int[] PT)
        {
            int[] CT = new int[PT.Length];
            for(int i = 0; i < PT.Length; ++i)
            {
                CT[i] = PT[i] ^ k[i];
            }
            return CT;
        }
        public int[] Decrypt(int[] CT)
        {
            int[] PT = new int[CT.Length];
            for(int i = 0; i < CT.Length; ++i)
            {
                PT[i] = CT[i] ^ k[i];
            }
            return PT;
        }
        public void ConvertString(string input, out int[] output)
        {
            output = new int[input.Length];
            for(int i = 0; i < input.Length; ++i)
            {
                output[i] = (int)input[i];
            }
        }
        public string ConvertArray(int[] input)
        {
            string output = "";
            for(int i = 0; i < input.Length; ++i)
            {
                output += Convert.ToChar(input[i]);
            }
            return output;
        }
        private void Swap(int[] S, int i, int j)
        {
            int temp = S[i];
            S[i] = S[j];
            S[j] = temp;
        }
    }
}
