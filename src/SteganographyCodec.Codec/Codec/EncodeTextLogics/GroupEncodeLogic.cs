using SteganographyCodec.Domain.Entities.Dto;

namespace SteganographyCodec.Codec.Codec.IncodeLogics
{
    public class GroupEncodeLogic
    {
        public static ColoredText EncodeString(string value)
        {
            int[] result1 = EncodeLogic.AlphabetStringIndex(value); // 13 2 2 46 2 3 
            int[] result2 = EncodeLogic.StringOriginIndex(value); // 0 1 1 2 3 
            int[] result3 = EncodeLogic.DistinctedAlphabetIndexArray(result1); // новий англійський алфавіт без повторень 
            char[] result4 = EncodeLogic.NewEncodedAlphabetWithColors(result3); // японський алфавіт 
            ColoredText result5 = EncodeLogic.ColoredAlphabetInText(result4); // кольори алфавіту
            ColoredText result = EncodeLogic.FullyColoredText(ref result5, result2); // повністю зафарбований текст
            return result;
        }
    }
}
