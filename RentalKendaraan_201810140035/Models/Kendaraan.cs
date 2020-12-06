using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong!!")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi tidak boleh kosong!!")]
        public string NoPolisi { get; set; }


        //[RegularExpression("^[0-9]^$", ErrorMessage = "No STNK hanya boleh di isi dengan angka")]
        [MinLength(6, ErrorMessage = "No STNK minimal 6 angka")]
        [MaxLength(8, ErrorMessage = "No STNK maksimal 8 angka")]
        [Required(ErrorMessage = "No STNK tidak boleh kosong!!")]
        public string NoStnk { get; set; }

        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersedian tidak boleh kosong!!")]
        //[RegularExpression("^[0-9]^$", ErrorMessage = "No STNK hanya boleh di isi dengan angka")]
        public string Ketersediaan { get; set; }

        [DisplayName("JenisKendaraan")]
        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
