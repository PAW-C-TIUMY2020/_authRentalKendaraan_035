using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Nama Jaminan tidak boleh kosong!!")]
        public string NamaJaminan { get; set; }

        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
