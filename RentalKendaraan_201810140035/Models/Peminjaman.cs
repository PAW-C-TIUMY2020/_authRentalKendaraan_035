using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [Key]
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }

        [DisplayName("Tanggal Peminjaman")]
        [Required(ErrorMessage = "Tanggal peminjaman wajib diisi!!")]
        public DateTime? TglPeminjaman { get; set; }

        [DisplayName("Kendaraan")]
        [Required(ErrorMessage = "Kendaraan wajib diisi!!")]
        public int? IdKendaraan { get; set; }

        [DisplayName("Customer")]
        [Required(ErrorMessage = "Customer wajib diisi!!")]
        public int? IdCustomer { get; set; }

        [DisplayName("Jaminan")]
        [Required(ErrorMessage = "Jaminan wajib diisi!!")]
        public int? IdJaminan { get; set; }

        //[RegularExpression("^[0-9]^$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "Biaya wajib diisi!!")]
        public int? Biaya { get; set; }

        [DisplayName("Customer")]
        public Customer IdCustomerNavigation { get; set; }
        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
