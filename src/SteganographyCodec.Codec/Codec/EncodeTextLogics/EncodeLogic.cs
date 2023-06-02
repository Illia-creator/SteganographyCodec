using SteganographyCodec.Domain.Enteties;
using SteganographyCodec.Domain.Entities.Dto;
using SteganographyCodec.Domain.Entities.Exceptions;
using System.Globalization;

namespace SteganographyCodec.Codec.Codec.IncodeLogics
{
    public static class EncodeLogic
    {
        public static char[] AlphabetIndexArray(string startStringValue)
        {
            char[] unpreparedArray = startStringValue.ToCharArray();
            return unpreparedArray.Distinct().ToArray();
        }

        public static char[] DistinctedAlphabetArray(string valueString)
        {
            char[] alphabetArray = AlphabetIndexArray(valueString); // Массив символов без повторений H l o w r d
            return alphabetArray;
        }

        public static int[] DistinctedAlphabetIndexArray(int[] value)
        {
            int[] distrinctedAlphabetIndex = value.Distinct().ToArray();
            return distrinctedAlphabetIndex;  // перезаписаный алфавит индексами 28 0 24 3
        }

        public static int[] StringOriginIndex(string valueString) // 1     
        {
            char[] value = valueString.ToCharArray();
            int[] characterIndex = new int[value.Length];
            char[] alphabetArray = DistinctedAlphabetArray(valueString);

            for (int i = 0; i < valueString.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(alphabetArray, value[i]);
            }

            return characterIndex; // Порядковые номера символов с повторениями 0 1 2 2 3 4 5
        }

        public static int[] AlphabetStringIndex(string valueString) // 2      
        {
            char[] value = valueString.ToCharArray();
            int[] characterIndex = new int[value.Length];

            for (int i = 0; i < valueString.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(Symbols.Alphabet, value[i]);
                if (characterIndex[i] < 0)
                    throw new InvalidSymbolException(value[i]);

            }

            return characterIndex;     // порядковые номера в алфавите английского языка 28 0 24 24 3 2 27
        }

        public static char[] NewEncodedAlphabetWithColors(int[] distrinctedAlphabetIndex) // 3    
        {
            char[] symbolsAlphabet = new char[distrinctedAlphabetIndex.Length];

            for (int i = 0; i < symbolsAlphabet.Length; i++)
            {
                symbolsAlphabet[i] = Symbols.NewAlphabet[(distrinctedAlphabetIndex[i])];
            }

            return symbolsAlphabet;
        }

        public static ColoredText ColoredAlphabetInText(char[] alphabetInSymbols) // 4
        {
            ColoredText coloredText = new ColoredText();

            coloredText.Text = Symbols.AlphabetText;

            coloredText.Colors = new List<string>();
            string[] colors = new string[coloredText.Text.Length];

            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = "#000000";
            }

            coloredText.Colors = colors.ToList();

            Random rnd = new Random();

            for (int i = 0; i < alphabetInSymbols.Length; i++)
            {              
                for (int j = 0; j < coloredText.Text.Length; j++)
                {                   
                    if (alphabetInSymbols[i] == coloredText.Text[j] && coloredText.Colors[j].ToString() == "#000000" && coloredText.Colors[j + 1].ToString() == "#000000")
                    {
                        coloredText.Colors[j] = "#050006";
                        j++;
                        

                        int tens = (i) / 10;
                        int ones = (i) % 10;
                        int hundreds = 0;

                        if (ones >= 5)
                        {
                            hundreds = ones - 5;
                            ones = 5;
                        }
                        else
                        {
                            hundreds = rnd.Next(0, 5);
                        }
                        coloredText.Colors[j] = $"#0{tens}0{hundreds}0{ones + 1}";
                        break;
                    }
                }
                
            }
            return coloredText;

        }

        public static ColoredText FullyColoredText(ref ColoredText coloredText, int[] stringOriginIndex)
        {
            int i = 0;

            Random rnd = new Random();

            for (int j = 0; j < coloredText.Text.Length; j++)
            {
                if (coloredText.Colors[j].ToString() == "#000000" && i<stringOriginIndex.Length)
                {
                    try
                    {
                        int tens = (stringOriginIndex[i]) / 10;
                        int ones = (stringOriginIndex[i]) % 10;
                        int hundreds = 0;

                        if (ones >= 4)
                        {
                            hundreds = ones - 4;
                            ones = 4;
                        }
                        else
                        {
                            hundreds = rnd.Next(0, 5);
                        }

                        coloredText.Colors[j] = $"#0{hundreds}0{tens}0{ones + 1}";

                        i++;
                    }
                    catch
                    {
                        Exception x;
                        break;
                    }
                }
                else j = j + 2;

                if (i == coloredText.Text.Length - 1)
                    throw new Exception("Text must be nearly 500 symbols or less");
            }

            return coloredText;
        }
    }
}
