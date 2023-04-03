using SteganographyCodec.Domain.Enteties.Files.Const;

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
    }
}
