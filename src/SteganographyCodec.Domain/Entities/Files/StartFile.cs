using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace SteganographyCodec.Domain.Enteties.Files
{
    public class StartFile : BaseFile
    {
        public StartFile(string pathToFile, bool isExist = true, bool isChangable = false) : base(pathToFile, isExist, isChangable)
        {
        }
        public string GetDataFromFile()
        {
            Word.Application application = new Word.Application();
            Word.Document wordDoc = application.Documents.Open(PathToFile);

            List<char> TextChars = new List<char>();
            List<string> TextColors = new List<string>();

            string result = null;

            foreach (Word.Range range in wordDoc.StoryRanges)
            {
                result = range.Text;
            }

            wordDoc.Close();
            application.Quit();
            Marshal.ReleaseComObject(application);

            return result;
        }

    }
}
