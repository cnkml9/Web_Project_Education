using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System;

namespace egitim.Entity
{
    public class Kullanici : IdentityUser
    {
        [Required]
        public string Ad { get; set; }
        public string telNo { get; set; }
        public string Mail { get; set; }
        [NotMapped]
        public string Role { get; set; }
        public DateTime KayitOlmaTarihi { get; set; }
        public DateTime KayitGuncelleme { get; set; }
        public bool Aktif { get; set; }

    }
}
