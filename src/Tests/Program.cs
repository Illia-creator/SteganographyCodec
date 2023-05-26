using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Application = Microsoft.Office.Interop.Word.Application;

class Program
{
    static void Main(string[] args)
    {

        //string filePath = @"C:\Users\sie29\Desktop\Hello.docx";

        //Application wordApp = new Application();
        //Document wordDoc = wordApp.Documents.Open(filePath);

        //string text = wordDoc.Content.Text;
        //wordDoc.Close();
        //wordApp.Quit();
        //Console.WriteLine("---------------------------------------------------------");
        //foreach (char c in text.ToCharArray())
        //{
        //    Console.Write("'\\x" + Convert.ToUInt16(c).ToString("X") + "', ");
        //}


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


        //string[] colorCodes = { "#FF0000", "#00FF00", "#0000FF", "#00FF00", "#0000FF", "#00FF00", "#0000FF", "#00FF00", "#0000FF", "#00FF00", "#0000FF" };

        //// Ваш массив символов
        //char[] charArray = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd' };

        //// Проверка на соответствие размеров массивов
        //if (colorCodes.Length != charArray.Length)
        //{
        //    Console.WriteLine("Ошибка: размеры массивов не совпадают.");
        //    Console.ReadLine();
        //    return;
        //}

        //// Преобразование массива символов в строку
        //string text = new string(charArray);

        //// Вставка текста в документ
        //wordDoc.Content.Text = text;

        //// Получение позиции текущего символа
        //int currentPosition = 1;

        //// Применение цвета к каждому символу в документе
        //for (int i = 0; i < colorCodes.Length; i++)
        //{
        //    // Получение текущего символа
        //    char currentChar = charArray[i];

        //    // Получение текущего цвета
        //    string colorCode = colorCodes[i];

        //    // Конвертация цвета из шестнадцатиричного формата в объект Color
        //    Color color = ColorTranslator.FromHtml(colorCode);

        //    // Выделение текущего символа
        //    Microsoft.Office.Interop.Word.Range range = wordDoc.Range(currentPosition, currentPosition + 1);
        //    range.Font.Color = (WdColor)ColorTranslator.ToOle(color);


        //    // Обновление позиции текущего символа
        //    currentPosition++;
        //}

        //// Сохранение документа
        //string filePathete = @"C:\Users\sie29\Desktop\ajg;ag;a.docx";
        //wordDoc.SaveAs(filePathete);




        //wordDoc.Close();
        //wordApp.Quit();


        //string path = @"C:\Users\sie29\Desktop\xfvhbjk;l.txt"; // Замените на путь к желаемому файлу
        //var text = File.ReadAllText(path).ToCharArray();

        //foreach (char element in text)
        //{
        //    Console.Write("'\\x" + Convert.ToUInt16(element).ToString("X") + "', ");
        //}
        //Console.WriteLine("");
        //Console.WriteLine("");
        //Console.WriteLine("");
        //var test = Symbols.AlphabetText;
        //var jg = Symbols.Alphabet;

        //char[] uniqueArray = Symbols.AlphabetText.Distinct().ToArray();
        //foreach (char element in uniqueArray)
        //{
        //    Console.Write("'\\x" + Convert.ToUInt16(element).ToString("X") + "', ");
        //}




        //int counter = 0;
        //int globalCounter = 0;
        //var copy = Symbols.NewAlphabet;
        //for (int i = 0; i < Symbols.NewAlphabet.Length; i++)
        //{
        //    counter = 0;
        //    for (int j = 0; j < Symbols.AlphabetText.Length; j++)
        //    {

        //        if (Symbols.AlphabetText[j] == Symbols.NewAlphabet[i])
        //        {
        //            counter++;

        //        }

        //    }
        //    if (counter <= 1)
        //    {
        //        copy[i] = '0';
        //        globalCounter++;
        //        Console.WriteLine("Place " + i);
        //        Console.WriteLine("Counter " + counter);
        //    }
        //}

        {
            int[] array = { 28, 0, 24, 3, 2, 60, 10, 6, 41, 50 };
            string filename = @"C:\Users\sie29\Desktop\Text Document.txt";
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                result += Symbols.NewAlphabet[i];
            }

            WriteStringToFile(result, filename);
        }

        static void WriteStringToFile(string text, string filename)
        {
            File.WriteAllText(filename, text);
            Console.WriteLine("Рядок було записано в файл.");
        }

    }
}
