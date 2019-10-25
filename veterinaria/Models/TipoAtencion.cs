using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("tipo_atencion")]
    public partial class TipoAtencion
    {
        public TipoAtencion()
        {
            Atencion = new HashSet<Atencion>();
        }

        [Column("id_tipo_atencion", TypeName = "int(11)")]
        public int IdTipoAtencion { get; set; }
        [Column("descripcion", TypeName = "varchar(80)")]
        public string Descripcion { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }

        [ForeignKey("UsuarioRut")]
        [InverseProperty("TipoAtencion")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("TipoAtencionIdTipoAtencionNavigation")]
        public virtual ICollection<Atencion> Atencion { get; set; }
    }
}
