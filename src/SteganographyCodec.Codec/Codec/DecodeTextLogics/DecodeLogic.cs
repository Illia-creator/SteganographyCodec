
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
                characterIndex[i] = Array.IndexOf(Symbols.NewAlphabet, charValue[i]);
            }

            return characterIndex;
        }

        public static int[] IncodeIndexArray(int[] value) // 2.1
        {
            int alphabetLength = value[value.Length - 1];
            int[] result = new int[value.Length - alphabetLength - 1];
            int helpIndex;

            for (int i = 0; i < alphabetLength; i++)
            {
                helpIndex = i * 2;
                result[i] = value[helpIndex];
            }

            helpIndex = alphabetLength * 2;

            for (int i = alphabetLength; i < result.Length; i++)
            {
                result[i] = value[helpIndex];
                helpIndex++;
            }

            return result;
         }

        public static int[] IncodeIndexAlphabetArray(int[] value) // 2.2
        {
            int[] result = new int[value[value.Length - 1]];
            int helpIndex = 1;


            for (int i = 0; i < result.Length; i++)
            {
                result[i] = value[helpIndex];
                helpIndex = helpIndex + 2;
            }

            return result;
        }

        public static char[] IncodeAlphabet(int[] value) // 3 
        {
            char[] result = new char[value.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Symbols.Alphabet[value[i]];
            }
            return result;
        }

        public static string DecodeString(char[] alphabet, int[] value) // 4
        {
            string result = null;

            for (int i = 0; i < value.Length; i++)
            {
                result = string.Concat(result, alphabet[value[i]]);
            }

            return result;
        }

    }
}
