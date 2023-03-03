using SteganographyCodec.Domain.Enteties;
using System.Runtime.Serialization.Formatters;

namespace SteganographyCodec.Codec.Codec.IncodeLogics
{
    public static class IncodeLogic
    {
        public static char[] AlphabetIndexArray(string startStringValue)
        {
            char[] unpreparedArray = startStringValue.ToCharArray();
            return unpreparedArray.Distinct().ToArray();
        }

        public static int[] StringOriginIndex(string valueString) // 1
        {
            char[] value = valueString.ToCharArray();
            int[] characterIndex = new int[value.Length];
            char[] alphabetArray = AlphabetIndexArray(valueString); // Массив символов без повторений

            for (int i = 0; i < valueString.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(alphabetArray, value[i]); // Порядковые номера символов с повторениями
            }

            return characterIndex;
        }

        public static int[] AlphabetStringIndex(string valueString) // 2
        {
            int incodeIndex;
            char[] value = valueString.ToCharArray();
            int[] characterIndex = new int[value.Length];

            for (int i = 0; i < valueString.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(Symbols.Alphabet, value[i]);
            }

            return characterIndex;
        }

        public static int[] ConcatAlphabetAndResult(int[] stringOriginIndex, int[] alphabetStringIndex) // 3
        {
            int[] result = new int[stringOriginIndex.Length * 2];
            int helpIndex;

            for (int i = 0; i < result.Length; i++)
            {
                helpIndex = i / 2;
                result[i] = stringOriginIndex[helpIndex];
                i++;
                result[i] = alphabetStringIndex[helpIndex];
            }

            return result;
        }

        public static string IncodeSymbolString(int[] incodeAlphabetString) // 4
        {
            string result = null;
            char incodeSymbol;
            for (int i = 0; i < incodeAlphabetString.Length; i++)
            {
                incodeSymbol = Symbols.IncodeSymbols[incodeAlphabetString[i]];
                result = string.Concat(result, incodeSymbol);
            }
            return result;
        }
    }
}
