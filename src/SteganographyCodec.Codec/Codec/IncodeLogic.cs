using SteganographyCodec.Domain.Enteties;

namespace SteganographyCodec.Codec.Codec
{
    public static class IncodeLogic
    {
        public static char[] AlphabetArray(string startStringValue)
        {
            char[] unpreparedArray = startStringValue.ToCharArray();
            return unpreparedArray.Distinct().ToArray();
        }

        public static int[] IncodeAlphabetString(string valueString)
        {
            char[] value = valueString.ToCharArray();
            int[] characterIndex = new int[value.Length];
            char[] alphabetArray = AlphabetArray(valueString); // Массив символов без повторений

            for (int i = 0; i < valueString.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(alphabetArray, value[i]); // Порядковые номера символов с повторениями
            }

           return characterIndex;
        }

        public static string IncodeSymbolString(int[] incodeAlphabetString)
        {
            string result=null;
            string incodeSymbol;
            for (int i = 0; i < incodeAlphabetString.Length; i++)
            {
                incodeSymbol = Symbols.IncodeSymbols[incodeAlphabetString[i]];
                result = string.Concat(result, incodeSymbol);
            }
            return result;
        }
    }
}
