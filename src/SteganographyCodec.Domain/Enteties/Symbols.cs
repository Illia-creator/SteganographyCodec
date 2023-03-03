namespace SteganographyCodec.Domain.Enteties
{
    public static class Symbols
    {
        public static char[] IncodeSymbols = {
            '\x16A0', '\x16A1', '\x16A2', '\x16A3', '\x16A4', '\x16A5', '\x16A6', '\x16A7', '\x16A8', '\x16A9',
            '\x16AA', '\x16AB', '\x16AC', '\x16AD', '\x16AE', '\x16AF',
            '\x16B0', '\x16B1', '\x16B2', '\x16B3', '\x16B4', '\x16B5', '\x16B6', '\x16B7', '\x16B8', '\x16B9',
            '\x16BA', '\x16BB', '\x16BC', '\x16BD', '\x16BE', '\x16BF',
            '\x16C0', '\x16C1', '\x16C2', '\x16C3', '\x16C4', '\x16C5', '\x16C6', '\x16C7', '\x16C8', '\x16C9',
            '\x16CA', '\x16CB', '\x16CC', '\x16CD', '\x16CE', '\x16CF',
            '\x16D0', '\x16D1', '\x16D2', '\x16D3', '\x16D4', '\x16D5', '\x16D6', '\x16D7', '\x16D8', '\x16D9',
            '\x16DA', '\x16DB', '\x16DC', '\x16DD', '\x16DE', '\x16DF',
            '\x16E0', '\x16E1', '\x16E2', '\x16E3', '\x16E4', '\x16E5', '\x16E6', '\x16E7', '\x16E8', '\x16E9',
            '\x16EA', '\x16EB', '\x16EC', '\x16ED', '\x16EE', '\x16EF' // 80
        };
        public static char[] Alphabet ={
            'e', 'a', ' ', 'o', 'i', '.', 'd', 'h', ',', 'n', 'r', 'E', 's', 't', 'A', 'u', 'y', 'O',
            'c', 'f', 'I', 'g', 'l', 'D', 'm', 'w', 'H', 'b', 'k', 'N', 'p', 'q', 'R', 'x', 'z', 'S',
            '?', '!', ';', ':', '-', '_', '+', '=', '/', '"', '\'', '\x00A7', 
            'T', 'U', 'Y', 'C', 'F', 'G', 'L', 'M', 'W', 'B', 'K', 'P', 'Q', 'X', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
                // ' ' . , ? ! ; : - _ = + / " '
        };
        
        public static void Swap<T>(this IList<T> array, int index1, int index2)
        {
            var temporary = array[index1];
            array[index1] = array[index2];
            array[index2] = temporary;
        }
    }
}
