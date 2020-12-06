using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_201810140035.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        [DisplayName("Customer")]
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong!!")]
        public string NamaCustomer { get; set; }

        //harus angka
        [Required(ErrorMessage = "NIK wajib diisi!!!")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat wajib diisi!!")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 angka")]
        [Required(ErrorMessage = "No HP wajib diisi!!!")]
        public string NoHp { get; set; }


        [DisplayName("Gender")]
        public int? IdGender { get; set; }

        [DisplayName("Gender")]
        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
