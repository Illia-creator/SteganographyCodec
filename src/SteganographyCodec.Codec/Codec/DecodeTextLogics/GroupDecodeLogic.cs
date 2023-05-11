namespace SteganographyCodec.Codec.Codec.DecodeLogics
{
    public static class GroupDecodeLogic
    {
        public static string Decoding(string value)
        {
            int[] result1 = DecodeLogic.IncodeIndexFullArray(value);
            int[] result21 = DecodeLogic.IncodeIndexArray(result1);
            int[] result22 = DecodeLogic.IncodeIndexAlphabetArray(result1);
            char[] result3 = DecodeLogic.IncodeAlphabet(result22);
            string result = DecodeLogic.DecodeString(result3, result21);
            return result;
        }
    }
}
