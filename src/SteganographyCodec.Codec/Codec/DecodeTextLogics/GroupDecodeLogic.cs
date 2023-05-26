using SteganographyCodec.Domain.Entities.Dto;

namespace SteganographyCodec.Codec.Codec.DecodeLogics
{
    public static class GroupDecodeLogic
    {
        public static string Decoding(ColoredText coloredText)
        {
            ColoredText result1 = DecodeLogic.SplitOnlyAlphabet(coloredText);
            char[] result2 = DecodeLogic.SortedAlphabet(result1);
            int[] result3 = DecodeLogic.NewAlphabetIndex(result2);
            string result = DecodeLogic.ResultMessage(coloredText, result3);
            return result;
        }
    }
}
