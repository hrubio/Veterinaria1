using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("aspnetroleclaims")]
    public partial class Aspnetroleclaims
    {
        [Column(TypeName = "int(11)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string RoleId { get; set; }
        [Column(TypeName = "longtext")]
        public string ClaimType { get; set; }
        [Column(TypeName = "longtext")]
        public string ClaimValue { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Aspnetroleclaims")]
        public virtual Aspnetroles Role { get; set; }
    }
}
