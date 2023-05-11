using Microsoft.Office.Interop.Word;
using SteganographyCodec.Domain.Enteties.Files.Const;
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
            using (FileStream file = new FileStream(PathToCreatedIncodeFileConst.PathTocreatedFile,
                FileMode.Create))
                IsExist = true;
            PathToFile = PathToCreatedIncodeFileConst.PathTocreatedFile;
        }
        
    }
}
