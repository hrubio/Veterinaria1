using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("rol")]
    public partial class Rol
    {
        [Column("id_rol", TypeName = "int(11)")]
        public int IdRol { get; set; }
        [Column("roles", TypeName = "varchar(45)")]
        public string Roles { get; set; }
        [Required]
        [Column("Usuarios_rut", TypeName = "varchar(15)")]
        public string UsuariosRut { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [ForeignKey("UsuariosRut")]
        [InverseProperty("Rol")]
        public virtual Usuario UsuariosRutNavigation { get; set; }
    }
}
