using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("aspnetuserroles")]
    public partial class Aspnetuserroles
    {
        [Column(TypeName = "varchar(255)")]
        public string UserId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("Aspnetuserroles")]
        public virtual Aspnetroles Role { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Aspnetuserroles")]
        public virtual Aspnetusers User { get; set; }
    }
}
