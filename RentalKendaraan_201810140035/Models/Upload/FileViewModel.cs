using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_201810140035.Models.Uploade
{
    public class FileDetails
    {
        public string Name { get; set; }

        public string Path { get; set; }
    }
    public class FilesViewModel
    {
        public List<FileDetails> files { get; set; }
        = new List<FileDetails>();
    }
}
