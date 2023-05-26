using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties.Files.Const;
using SteganographyCodec.Domain.Entities.Dto;
using System.Drawing;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace SteganographyCodec.Domain.Enteties.Files
{
    public class IncodeFile : BaseFile
    {
        public IncodeFile(string pathToFile = "", bool isExist = false, bool isChangable = true) : base(pathToFile, isExist, isChangable)
        {
            if (IsExist == false)
                CreateFile();
        }
        public void CreateFile()
        {
            PathToFile = PathToCreatedIncodeFileConst.PathToCreatedFile;

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

            for (int i = 0; i < coloredText.Colors.Count; i++)
            {
                // Получение текущего цвета
                string colorCode = coloredText.Colors[i];

                // Конвертация цвета из шестнадцатиричного формата в объект Color
                Color color = ColorTranslator.FromHtml(colorCode);

                // Выделение текущего символа
                Word.Range range = doc.Range(currentPosition, currentPosition + 1);
                range.Font.Color = (WdColor)ColorTranslator.ToOle(color);

                // Обновление позиции текущего символа
                currentPosition++;
            }

            doc.SaveAs(PathToFile);

            doc.Close();

            wordApp.Quit();

        }

    }
}
