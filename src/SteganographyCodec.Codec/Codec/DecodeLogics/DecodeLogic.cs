
using SteganographyCodec.Domain.Enteties;

namespace SteganographyCodec.Codec.Codec.DecodeLogics
{
    public static class DecodeLogic
    {
        public static int[] IncodeIndexFullArray(string value) // 1
        {
            int[] characterIndex = new int[value.Length - 2];
            char[] charValue = value.ToCharArray();

            for (int i = 0; i < characterIndex.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(Symbols.IncodeSymbols, charValue[i]);
            }

            return characterIndex;
        
        }

        public static int[] IncodeIndexArray(int[] value) // 2.1
        {
            int[] result = new int[value.Length / 2];
            int helpIndex;

            for (int i = 0; i < result.Length; i++)
            {
                helpIndex = i * 2;
                result[i] = value[helpIndex];
            }

            return result;
        }

        public static int[] IncodeIndexAlphabetArray(int[] value) // 2.2
        {
            int[] result = new int[value.Length / 2];
            int helpIndex = 1;

            for (int i = 1; i < result.Length; i++)
            {
                helpIndex = helpIndex + 2;
                result[i] = value[helpIndex];
            }

            return result;
        }

        public static char[] IncodeAlphabet(int[] value) // 3 
        {
            char[] result = new char[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                result[i] = Symbols.Alphabet[value[i]];
            }
            return result;
        }

        public static string DecodeString(char[] alphabet, int[] value) // 4
        {
            string result = null;
            char[] resultAlplhabet = alphabet.Distinct().ToArray(); // КОСТЫЛЬ 

            for (int i = 0; i < value.Length; i++)
            {
                result = string.Concat(result, resultAlplhabet[value[i]]);
            }

            return result;
        }

    }
}
