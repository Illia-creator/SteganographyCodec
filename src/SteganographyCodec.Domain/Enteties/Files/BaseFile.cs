using SteganographyCodec.Domain.Enteties.Files.Const;

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
            if (IsExist == false)
                CreateFile();
        }

        public void CreateFile()
        {
            using (FileStream file = new FileStream(PathToCreatedFileConst.PathTocreatedFile,
                FileMode.Create))
            IsExist = true;
            PathToFile = PathToCreatedFileConst.PathTocreatedFile;
        }

        public void WriteDataInFile(string incodeData)
        {
            using (StreamWriter writer = new StreamWriter(PathToFile))
                writer.WriteLineAsync(incodeData);
        }

        public string GetDataFromFile()
        {
            string value = File.ReadAllText(PathToFile);
            return value;
        }
    }
}
