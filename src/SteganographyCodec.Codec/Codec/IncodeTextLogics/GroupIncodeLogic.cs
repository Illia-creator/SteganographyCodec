using SteganographyCodec.Domain.Entities.Dto;

namespace SteganographyCodec.Codec.Codec.IncodeLogics
{
    public class GroupIncodeLogic
    {
        public static ColoredText IncodeString(string value)
        {
            int[] result1 = IncodeLogic.AlphabetStringIndex(value); // 13 2 2 46 2 3 
            int[] result2 = IncodeLogic.StringOriginIndex(value); // 0 1 1 2 3 
            int[] result3 = IncodeLogic.DistinctedAlphabetIndexArray(result1); // новий англійський алфавіт без повторень 
            char[] result4 = IncodeLogic.NewIncodedAlphabetWithColors(result3); // японський алфавіт 
            ColoredText result5 = IncodeLogic.ColoredAlphabetInText(result4); // кольори алфавіту
            ColoredText result = IncodeLogic.FullyColoredText(ref result5, result2); // повністю зафарбований текст
            return result;
        }
    }
}
