using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_201810140035.Models.Uploade
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}

