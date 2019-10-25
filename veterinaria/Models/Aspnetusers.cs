using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("aspnetusers")]
    public partial class Aspnetusers
    {
        public Aspnetusers()
        {
            Aspnetuserclaims = new HashSet<Aspnetuserclaims>();
            Aspnetuserlogins = new HashSet<Aspnetuserlogins>();
            Aspnetuserroles = new HashSet<Aspnetuserroles>();
            Aspnetusertokens = new HashSet<Aspnetusertokens>();
        }

        [Column(TypeName = "varchar(255)")]
        public string Id { get; set; }
        [Column(TypeName = "varchar(256)")]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(256)")]
        public string NormalizedUserName { get; set; }
        [Column(TypeName = "varchar(256)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(256)")]
        public string NormalizedEmail { get; set; }
        [Column(TypeName = "bit(1)")]
        public bool EmailConfirmed { get; set; }
        [Column(TypeName = "longtext")]
        public string PasswordHash { get; set; }
        [Column(TypeName = "longtext")]
        public string SecurityStamp { get; set; }
        [Column(TypeName = "longtext")]
        public string ConcurrencyStamp { get; set; }
        [Column(TypeName = "longtext")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "bit(1)")]
        public bool PhoneNumberConfirmed { get; set; }
        [Column(TypeName = "bit(1)")]
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        [Column(TypeName = "bit(1)")]
        public bool LockoutEnabled { get; set; }
        [Column(TypeName = "int(11)")]
        public int AccessFailedCount { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Aspnetuserroles> Aspnetuserroles { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Aspnetusertokens> Aspnetusertokens { get; set; }
    }
}
