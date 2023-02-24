namespace SteganographyCodec.Domain.Enteties.Files
{
    public class StartFile : BaseFile
    {
        public StartFile(string pathToFile, bool isExist = true, bool isChangable = false) : base(pathToFile, isExist, isChangable)
        {
        }
    }
}
