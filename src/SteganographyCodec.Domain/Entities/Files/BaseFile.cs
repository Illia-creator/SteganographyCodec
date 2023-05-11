using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace SteganographyCodec.Domain.Enteties.Files
{
    public class BaseFile
    {
        public string PathToFile { get; set; }
        public bool IsExist { get; set; }
        public bool IsChangable { get; set; }

        public BaseFile(string pathToFile, bool isExist, bool isChangable)
        {
            PathToFile = pathToFile;
            IsExist = isExist;
            IsChangable = isChangable;
        }

        public void WriteDataInFile(string incodeData)
        {
            using (StreamWriter writer = new StreamWriter(PathToFile))
                writer.WriteLineAsync(incodeData);

        }

       
    }
}
