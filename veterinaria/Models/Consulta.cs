using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("consulta")]
    public partial class Consulta
    {
        public Consulta()
        {
            Hora = new HashSet<Hora>();
        }

        [Column("id_consulta", TypeName = "int(11)")]
        public int IdConsulta { get; set; }
        [Column("descripcion", TypeName = "varchar(80)")]
        public string Descripcion { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }

        [ForeignKey("UsuarioRut")]
        [InverseProperty("Consulta")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("ConsultaIdConsultaNavigation")]
        public virtual ICollection<Hora> Hora { get; set; }
    }
}
