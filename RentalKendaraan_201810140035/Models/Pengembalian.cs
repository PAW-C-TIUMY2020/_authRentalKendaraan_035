using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tanggal pengembalian tidak boleh kosong!!")]
        public DateTime? TglPengembalian { get; set; }

        [Required(ErrorMessage = "Peminjaman tidak boleh kosong!!")]
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Kondisi tidak boleh kosong!!")]
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Denda tidak boleh kosong!!")]
        public int? Denda { get; set; }

        [DisplayName("Kondisi")]
        public KondisiKendaraan IdKondisiNavigation { get; set; }

        [DisplayName("Peminjaman")]
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
