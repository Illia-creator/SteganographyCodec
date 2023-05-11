using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Application = Microsoft.Office.Interop.Word.Application;

class Program
{
    static void Main(string[] args)
    {

        string filePath = @"C:\Users\sie29\Desktop\Hello.docx";

        Application wordApp = new Application();
        Document wordDoc = wordApp.Documents.Open(filePath);

        string text = wordDoc.Content.Text;
        wordDoc.Close();
        wordApp.Quit();
        Console.WriteLine("---------------------------------------------------------");
        foreach (char c in text.ToCharArray())
        {
            Console.Write("'\\x" + Convert.ToUInt16(c).ToString("X") + "', ");
        }


        //HashSet<char> uniqueChars = new HashSet<char>(Symbols.AlphabetText);
        //char[] resultArray = new char[uniqueChars.Count];
        //uniqueChars.CopyTo(resultArray);
        //Console.WriteLine("---------------------------------------------------------");
        //foreach (char c in resultArray)
        //{
        //    Console.Write("'\\x" + Convert.ToUInt16(c).ToString("X") + "', ");
        //}




        //// Создаем объект приложения Word
        //Application word = new Application();

        //// Создаем новый документ Word
        //Document document = word.Documents.Add();


        //string result = "";
        //// Записываем строку в документ
        //foreach (char chards in Symbols.NewAlphabet)
        //{
        //    result += chards;
        //}

        //Paragraph para = document.Content.Paragraphs.Add();
        //para.Range.Text = result;

        //// Сохраняем документ
        //object fileName = @"C:\Users\sie29\Desktop\Hello.docx";
        //document.SaveAs2(ref fileName);

        //// Закрываем документ и приложение Word
        //document.Close();
        //word.Quit();

        //foreach (Microsoft.Office.Interop.Word.Range range in wordDoc.StoryRanges)
        //{
        //    foreach (Microsoft.Office.Interop.Word.Range characterRange in range.Characters)
        //    {
        //        // Получение цвета символа
        //        var colorValue = characterRange.Font.Color.ToString("X");

        //        // Преобразование цвета в формат RGB
        //        //Color color = ColorTranslator.FromOle(colorValue);
        //        //var intcolor = color.ToString();
        //        //int red = color.R;
        //        //int green = color.G;
        //        //int blue = color.B;

        //        //// Вывод символа и его цвета
        //        //Console.WriteLine("Символ: " + characterRange.Text + ", Цвет: RGB(" + red + ", " + green + ", " + blue + ")");
        //    }
        //}

        wordDoc.Close();
        wordApp.Quit();
        //string text = "";
        //foreach (char e in Symbols.NewAlphabet)
        //{ 
        //    text += e.ToString();
        //}
        //string path = @"C:\Users\sie29\Desktop\Text Document.txt"; // Замените на путь к желаемому файлу


        //File.WriteAllText(path, text);

        //foreach (char element in Symbols.NewAlphabet)
        //{
        //    if (Array.IndexOf(Symbols.AlphabetText, element) != -1)
        //    {

        //    }
        //    else
        //    { Console.Write("'\\x" + Convert.ToUInt16(element).ToString("X") + "', "); }
        //}
    }
}
