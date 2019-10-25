using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("aspnetuserlogins")]
    public partial class Aspnetuserlogins
    {
        [Column(TypeName = "varchar(128)")]
        public string LoginProvider { get; set; }
        [Column(TypeName = "varchar(128)")]
        public string ProviderKey { get; set; }
        [Column(TypeName = "longtext")]
        public string ProviderDisplayName { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Aspnetuserlogins")]
        public virtual Aspnetusers User { get; set; }
    }
}
