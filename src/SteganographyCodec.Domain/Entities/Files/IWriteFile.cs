using SteganographyCodec.Domain.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteganographyCodec.Domain.Entities.Files
{
    public interface IWriteFile
    {
        public void CreateFile();
    }
}
