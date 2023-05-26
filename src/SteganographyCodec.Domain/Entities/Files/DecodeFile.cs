using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties.Files.Const;
using SteganographyCodec.Domain.Entities.Dto;

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
            PathToFile = PathToCreatedDecodeFileConst.PathToCreatedFile;

            Application wordApp = new Application();

            Document doc = wordApp.Documents.Add();

            doc.SaveAs(PathToFile);

            doc.Close();

            wordApp.Quit();

            IsExist = true;
        }
        public void WriteDataInFile(string message)
        {
            Application wordApp = new Application();
            
            Document doc = wordApp.Documents.Add();

            Paragraphs paragraphs = doc.Paragraphs;

            Paragraph paragraph = paragraphs.Add();

            paragraph.Range.Text = message;

            doc.SaveAs(PathToFile);

            doc.Close();
            wordApp.Quit();
        }
    }

}
