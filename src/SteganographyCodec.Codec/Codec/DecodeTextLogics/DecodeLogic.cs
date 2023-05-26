using SteganographyCodec.Domain.Enteties;
using SteganographyCodec.Domain.Entities.Dto;
using System.Text;

namespace SteganographyCodec.Codec.Codec.DecodeLogics
{
    public static class DecodeLogic
    {
        public static ColoredText SplitOnlyAlphabet(ColoredText firstColoredText) // 1
        {
            ColoredText alphabetColoredText = new ColoredText();

            List<char> symbols = new List<char>();
            List<string> colors = new List<string>();

            for (int i = 0; i < firstColoredText.Colors.Count; i++)
            {
                if (firstColoredText.Colors[i] == "00060005")
                {
                    symbols.Add(firstColoredText.Text[i]);
                    firstColoredText.Colors[i] = "00000000";
                    i++;
                    colors.Add(firstColoredText.Colors[i]);
                    firstColoredText.Colors[i] = "00000000";
                }
            }

            alphabetColoredText.Text = symbols.ToArray();
            alphabetColoredText.Colors = colors;

            return alphabetColoredText;
        }

        public static char[] SortedAlphabet(ColoredText splitOnlyAlphabet)
        {
            int ones;
            int tens;
            int hundreds = 0;

            List<int> order = new List<int>();

            for (int i = 0; i < splitOnlyAlphabet.Colors.Count; i++)
            {
                tens = Convert.ToInt32(splitOnlyAlphabet.Colors[i].Substring(6, 2));
                ones = Convert.ToInt32(splitOnlyAlphabet.Colors[i].Substring(2, 2));

                if (ones > 5)
                {
                    hundreds = Convert.ToInt32(splitOnlyAlphabet.Colors[i].Substring(4, 2));

                    ones = 6 + hundreds;
                }

                order.Add(tens * 10 + ones - 1);
            }

            bool swapped;

            for (int i = 0; i < order.Count; i++)
            {
                swapped = false;

                for (int j = 0; j < order.Count - i - 1; j++)
                {
                    if (order[j] > order[j + 1])
                    {
                        int temp = order[j];
                        char tempChar = splitOnlyAlphabet.Text[j];

                        order[j] = order[j + 1];
                        splitOnlyAlphabet.Text[j] = splitOnlyAlphabet.Text[j + 1];

                        order[j + 1] = temp;
                        splitOnlyAlphabet.Text[j + 1] = tempChar;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return splitOnlyAlphabet.Text;
        }

        public static int[] NewAlphabetIndex(char[] symbols)
        {
            int[] result = new int[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                for (int j = 0; j < Symbols.NewAlphabet.Length; j++)
                {
                    if (symbols[i] == Symbols.NewAlphabet[j])
                    {
                        result[i] = j;
                        break;
                    }
                }
            }
            return result;
        }

        public static string ResultMessage(ColoredText coloredText, int[] index)
        {
            StringBuilder builder = new StringBuilder();

            List<int> textIndexes = new List<int>();

            char symbol;

            int ones;
            int tens;
            int hundreds = 0;

            List<string> input = new List<string>();

            for (int i = 0; i < coloredText.Colors.Count - 1; i++)
            {
                if (coloredText.Colors[i] != "00000000")
                {
                    input.Add(coloredText.Colors[i]);                   
                }
            }

            for (int i = 0; i < input.Count; i++)
            {
                ones = Convert.ToInt32(input[i].Substring(2, 2));
                tens = Convert.ToInt32(input[i].Substring(4, 2));

                if (ones >= 5)
                {
                    hundreds = Convert.ToInt32(input[i].Substring(6, 2));

                    ones = 5 + hundreds;
                }                
                textIndexes.Add(tens * 10 + ones - 1);
            }

            for (int i = 0; i < textIndexes.Count; i++)
            {
                symbol = Symbols.Alphabet[index[textIndexes[i]]];

                builder.Append(symbol);
            }

             return builder.ToString();        
        }
    }
}
