using SteganographyCodec.Codec.Codec.DecodeLogics;
using SteganographyCodec.Domain;
using SteganographyCodec.Domain.Enteties.Files;
using SteganographyCodec.Domain.Entities.Dto;

namespace SteganographyCodec.Codec.Files
{
    public static class DecodeFileProcess
    {
        public static string startPath = BusClass.value;

        public static void Decoding()
        {
            StartFile startFile = new StartFile(startPath);
            ColoredText value = startFile.GetIncodedDataFromFile();

            string result = GroupDecodeLogic.Decoding(value);

            DecodeFile decodeFile = new DecodeFile();
            decodeFile.WriteDataInFile(result);
        }
    }
}
