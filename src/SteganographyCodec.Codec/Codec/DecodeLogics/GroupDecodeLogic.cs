namespace SteganographyCodec.Codec.Codec.DecodeLogics
{
    public static class GroupDecodeLogic
    {
        public static string Decoding(string value)
        {
            int[] result1 = DecodeLogic.IncodeIndexFullArray(value);
            int[] result2 = DecodeLogic.IncodeIndexArray(result1);
            return null;
        }
    }
}
