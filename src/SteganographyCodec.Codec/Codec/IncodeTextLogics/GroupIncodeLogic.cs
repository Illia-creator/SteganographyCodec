using SteganographyCodec.Domain.Entities.Dto;

namespace SteganographyCodec.Codec.Codec.IncodeLogics
{
    public class GroupIncodeLogic
    {
        public static string IncodeString(string value)
        {
            int[] result1 = IncodeLogic.AlphabetStringIndex(value);
            int[] result2 = IncodeLogic.StringOriginIndex(value);
            int[] result3 = IncodeLogic.DistinctedAlphabetIndexArray(result1);
            char[] result4 = IncodeLogic.NewIncodedAlphabetWithColors(result3);
            ColoredText result5 = IncodeLogic.ColoredAlphabetInText(result4);
            ColoredText result6 = IncodeLogic.FullyColoredText(ref result5, result2);
            // string result = IncodeLogic.IncodeSymbolString(result4);
            return null;
        }
    }
}
