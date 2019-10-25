using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("usuario")]
    public partial class Usuario
    {
        public Usuario()
        {
            AtencionUsuarioRut1Navigation = new HashSet<Atencion>();
            AtencionUsuarioRutNavigation = new HashSet<Atencion>();
            Cliente = new HashSet<Cliente>();
            Consulta = new HashSet<Consulta>();
            Especie = new HashSet<Especie>();
            Hora = new HashSet<Hora>();
            Mascota = new HashSet<Mascota>();
            Peluqueria = new HashSet<Peluqueria>();
            Presupuesto = new HashSet<Presupuesto>();
            Raza = new HashSet<Raza>();
            Rol = new HashSet<Rol>();
            TipoAtencion = new HashSet<TipoAtencion>();
        }

        [Column("rut", TypeName = "varchar(15)")]
        public string Rut { get; set; }
        [Column("nombre", TypeName = "varchar(200)")]
        public string Nombre { get; set; }
        [Column("apellido", TypeName = "varchar(200)")]
        public string Apellido { get; set; }
        [Column("correo", TypeName = "varchar(100)")]
        public string Correo { get; set; }
        [Column("contrasena", TypeName = "varchar(300)")]
        public string Contrasena { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [InverseProperty("UsuarioRut1Navigation")]
        public virtual ICollection<Atencion> AtencionUsuarioRut1Navigation { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<Atencion> AtencionUsuarioRutNavigation { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<Cliente> Cliente { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<Consulta> Consulta { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<Especie> Especie { get; set; }
        [InverseProperty("UsuariosRutNavigation")]
        public virtual ICollection<Hora> Hora { get; set; }
        [InverseProperty("UsuariosRutNavigation")]
        public virtual ICollection<Mascota> Mascota { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<Peluqueria> Peluqueria { get; set; }
        [InverseProperty("UsuariosRutNavigation")]
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<Raza> Raza { get; set; }
        [InverseProperty("UsuariosRutNavigation")]
        public virtual ICollection<Rol> Rol { get; set; }
        [InverseProperty("UsuarioRutNavigation")]
        public virtual ICollection<TipoAtencion> TipoAtencion { get; set; }
    }
}
