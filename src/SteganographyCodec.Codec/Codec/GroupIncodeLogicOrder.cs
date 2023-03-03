namespace SteganographyCodec.Codec.Codec
{
    public class GroupIncodeLogicOrder
    {
        public static string IncodeString(string value)
        {
            int[] result1 = IncodeLogic.AlphabetStringIndex(value);
            int[] result2 = IncodeLogic.StringOriginIndex(value);
            int[] result3 = IncodeLogic.ConcatAlphabetAndResult(result1, result2);
            string result = IncodeLogic.IncodeSymbolString(result3);
            return result;
        }
    }
}
