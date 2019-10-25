using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("raza")]
    public partial class Raza
    {
        public Raza()
        {
            Mascota = new HashSet<Mascota>();
        }

        [Column("id_raza", TypeName = "int(11)")]
        public int IdRaza { get; set; }
        [Column("Raza", TypeName = "varchar(100)")]
        public string Raza1 { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }

        [ForeignKey("UsuarioRut")]
        [InverseProperty("Raza")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("RazaIdRazaNavigation")]
        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
