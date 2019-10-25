using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("aspnetuserclaims")]
    public partial class Aspnetuserclaims
    {
        [Column(TypeName = "int(11)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string UserId { get; set; }
        [Column(TypeName = "longtext")]
        public string ClaimType { get; set; }
        [Column(TypeName = "longtext")]
        public string ClaimValue { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Aspnetuserclaims")]
        public virtual Aspnetusers User { get; set; }
    }
}
