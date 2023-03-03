
using SteganographyCodec.Domain.Enteties;

namespace SteganographyCodec.Codec.Codec.DecodeLogics
{
    public static class DecodeLogic
    {
        public static int[] IncodeIndexFullArray(string value) // 1
        {
            int[] characterIndex = new int[value.Length];
            char[] charValue = value.ToCharArray();

            for (int i = 0; i < value.Length; i++)
            {
                characterIndex[i] = Array.IndexOf(Symbols.IncodeSymbols, charValue[i]); 
            }

            return characterIndex;
        }

        public static int[] IncodeIndexArray(int[] value)
        {
            int[] result = new int[value.Length/2];
            int helpIndex;

            for (int i = 0; i < result.Length; i++)
            {
                helpIndex = i * 2;
                result[i] = value[helpIndex];
            }

            return result;
        }
    }
}
