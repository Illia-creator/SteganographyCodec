using SteganographyCodec.Codec.Codec.IncodeLogics;
using SteganographyCodec.Domain;
using SteganographyCodec.Domain.Enteties.Files;
using SteganographyCodec.Domain.Entities.Dto;

namespace SteganographyCodec.Codec.Files
{
    public static class EncodeFileProcess
    {
        public static string startPath = BusClass.value;

        public static void Encoding()
        {
            StartFile startFile = new StartFile(startPath);
            string value = startFile.GetDataFromFile();

            ColoredText result = GroupEncodeLogic.EncodeString(value);

            EncodeFile encodeFile = new EncodeFile();
            encodeFile.WriteDataInFile(result);
        }
    }
}
