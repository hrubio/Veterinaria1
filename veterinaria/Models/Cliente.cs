using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Hora = new HashSet<Hora>();
            Mascota = new HashSet<Mascota>();
            Presupuesto = new HashSet<Presupuesto>();
        }

        [Column("rut", TypeName = "varchar(15)")]
        public string Rut { get; set; }
        [Column("nombres", TypeName = "varchar(100)")]
        public string Nombres { get; set; }
        [Column("apellidos", TypeName = "varchar(100)")]
        public string Apellidos { get; set; }
        [Column("direccion", TypeName = "varchar(200)")]
        public string Direccion { get; set; }
        [Column("cuidad_localidad", TypeName = "varchar(100)")]
        public string CuidadLocalidad { get; set; }
        [Column("numero_contacto_1", TypeName = "varchar(15)")]
        public string NumeroContacto1 { get; set; }
        [Column("numero_contacto_2", TypeName = "varchar(15)")]
        public string NumeroContacto2 { get; set; }
        [Column("correo", TypeName = "varchar(80)")]
        public string Correo { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }

        [ForeignKey("UsuarioRut")]
        [InverseProperty("Cliente")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("ClientesRutNavigation")]
        public virtual ICollection<Hora> Hora { get; set; }
        [InverseProperty("ClientesRutNavigation")]
        public virtual ICollection<Mascota> Mascota { get; set; }
        [InverseProperty("ClientesRutNavigation")]
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
    }
}
