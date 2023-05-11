using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties.Files.Const;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace SteganographyCodec.Domain.Enteties.Files
{
    public class DecodeFile : BaseFile
    {
        public DecodeFile(string pathToFile = "", bool isExist = false, bool isChangable = true) : base(pathToFile, isExist, isChangable)
        {
            if (IsExist == false)
                CreateFile();
        }
        public void CreateFile()
        {
            using (FileStream file = new FileStream(PathToCreatedDecodeFileConst.PathToCreatedFile,
                FileMode.Create))
                IsExist = true;
            PathToFile = PathToCreatedDecodeFileConst.PathToCreatedFile;
        }
        public string GetDataFromFile()
        {
            Word.Application application = new Word.Application();
            Word.Document wordDoc = application.Documents.Open(PathToFile);

            List<char> TextChars = new List<char>();
            List<string> TextColors = new List<string>();

            foreach (Word.Range range in wordDoc.StoryRanges)
            {
                foreach (Word.Range character in range.Characters)
                {
                    var colorValue = character.Font.Color.ToString("X");


                    TextColors.Add(colorValue);
                    TextChars.Add(Convert.ToChar(character.Text));

                }
            }

            wordDoc.Close();
            application.Quit();
            Marshal.ReleaseComObject(application);

            return null;
        }
    }
}
