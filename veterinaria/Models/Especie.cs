using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("especie")]
    public partial class Especie
    {
        public Especie()
        {
            Mascota = new HashSet<Mascota>();
        }

        [Column("id_especie", TypeName = "int(11)")]
        public int IdEspecie { get; set; }
        [Column("especie", TypeName = "varchar(90)")]
        public string Especie1 { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }

        [ForeignKey("UsuarioRut")]
        [InverseProperty("Especie")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("EspecieIdEspecieNavigation")]
        public virtual ICollection<Mascota> Mascota { get; set; }
    }
}
