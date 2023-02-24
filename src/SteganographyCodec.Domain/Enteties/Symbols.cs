namespace SteganographyCodec.Domain.Enteties
{
    public static class Symbols
    {
        public static string[] IncodeSymbols = { "\x0C00", "\x0C01", "\x0C02", "\x0C03", "\x0C04", "\x0C05",
            "\x0C06", "\x0C07", "\x0C08", "\x0C09", "\x0C0A", "\x0C0B", "\x0C0C", "\x0C0E", "\x0C0F",
            "\x0C10", "\x0C12", "\x0C13", "\x0C14", "\x0C15", "\x0C16", "\x0C17", "\x0C18", "\x0C19",
            "\x0C1A", "\x0C1B", "\x0C1C", "\x0C1D", "\x0C1E", "\x0C1F", "\x0C20", "\x0C21", "\x0C22",
            "\x0C23", "\x0C24", "\x0C25", "\x0C26", "\x0C27", "\x0C28", "\x0C2A", "\x0C2B", "\x0C2C",
            "\x0C2D", "\x0C2E", "\x0C2F", "\x0C30", "\x0C31", "\x0C32", "\x0C33", "\x0C34", "\x0C35",
            "\x0C36", "\x0C37", "\x0C38", "\x0C39", "\x0C3D", "\x0C3E", "\x0C3F", "\x0C41", "\x0C42",
            "\x0C43", "\x0C44", "\x0C46", "\x0C47", "\x0C48", "\x0C4A", "\x0C4B", "\x0C4C", "\x0C4D",
            "\x0C55", "\x0C46"
        }; //71

        public static string[] Alpabet = {"A","B","C","D","E","F","G","H","I","J","K","L",
            "M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n",
            "o","p","q","r","s","t","u","v","w","x","y","z",
            ".", ",", " ", "?", "!", "-" };

        public static void Swap<T>(this IList<T> array, int index1, int index2)
        {
            var temporary = array[index1];
            array[index1] = array[index2];
            array[index2] = temporary;
        }
    }
}
