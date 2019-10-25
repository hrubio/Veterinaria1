using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("aspnetusertokens")]
    public partial class Aspnetusertokens
    {
        [Column(TypeName = "varchar(255)")]
        public string UserId { get; set; }
        [Column(TypeName = "varchar(128)")]
        public string LoginProvider { get; set; }
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }
        [Column(TypeName = "longtext")]
        public string Value { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Aspnetusertokens")]
        public virtual Aspnetusers User { get; set; }
    }
}
