using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties.Files.Const;
using SteganographyCodec.Domain.Entities.Dto;
using SteganographyCodec.Domain.Entities.Files;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace SteganographyCodec.Domain.Enteties.Files
{
    public class EncodeFile : BaseFile, IWriteFile
    {
        public EncodeFile(string pathToFile = "", bool isExist = false, bool isChangable = true) : base(pathToFile, isExist, isChangable)
        {
            if (IsExist == false)
                CreateFile();
        }
        public void CreateFile()
        {
            PathToFile = PathToCreatedEncodeFileConst.PathToCreatedFile;

            Application wordApp = new Application();

            Document doc = wordApp.Documents.Add();

            doc.SaveAs(PathToFile);

            doc.Close();

            wordApp.Quit();

            IsExist = true;
        }

        public void WriteDataInFile(ColoredText coloredText)
        {
            Application wordApp = new Application();

            Document doc = wordApp.Documents.Add();

            string text = new string(coloredText.Text);

            doc.Content.Text = text;

            int currentPosition = 0;
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < coloredText.Colors.Count; i++)
            {

                string colorCode = coloredText.Colors[i];
                Word.Range range = doc.Range(currentPosition, currentPosition + 1);

                if (colorCode != "#000000")
                {
                    Color color = ColorTranslator.FromHtml(colorCode);
                    range.Font.Color = (WdColor)ColorTranslator.ToOle(color);
                }              
                
                currentPosition++;
            }

            sw.Stop();
            var ds =sw.Elapsed;

            doc.SaveAs(PathToFile);

            doc.Close();

            wordApp.Quit();

        }

    }
}
