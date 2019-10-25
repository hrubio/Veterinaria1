using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("mascota")]
    public partial class Mascota
    {
        public Mascota()
        {
            Atencion = new HashSet<Atencion>();
            Hora = new HashSet<Hora>();
            Peluqueria = new HashSet<Peluqueria>();
        }

        [Column("num_ficha", TypeName = "int(11)")]
        public int NumFicha { get; set; }
        [Column("num_chip", TypeName = "varchar(45)")]
        public string NumChip { get; set; }
        [Column("foto", TypeName = "tinyblob")]
        public byte[] Foto { get; set; }
        [Column("nombre", TypeName = "varchar(100)")]
        public string Nombre { get; set; }
        [Column("fecha_nacimiento", TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }
        [Column("fecha_ingreso", TypeName = "date")]
        public DateTime? FechaIngreso { get; set; }
        [Column("tamaño", TypeName = "varchar(90)")]
        public string Tamaño { get; set; }
        [Column("sexo", TypeName = "varchar(20)")]
        public string Sexo { get; set; }
        [Column("color", TypeName = "varchar(30)")]
        public string Color { get; set; }
        [Column("deceso", TypeName = "varchar(10)")]
        public string Deceso { get; set; }
        [Column("observacion", TypeName = "varchar(300)")]
        public string Observacion { get; set; }
        [Column("fecha_deceso", TypeName = "date")]
        public DateTime? FechaDeceso { get; set; }
        [Column("causa_deceso", TypeName = "varchar(300)")]
        public string CausaDeceso { get; set; }
        [Required]
        [Column("Clientes_rut", TypeName = "varchar(15)")]
        public string ClientesRut { get; set; }
        [Column("Raza_id_raza", TypeName = "int(11)")]
        public int RazaIdRaza { get; set; }
        [Column("Especie_id_especie", TypeName = "int(11)")]
        public int EspecieIdEspecie { get; set; }
        [Required]
        [Column("Usuarios_rut", TypeName = "varchar(15)")]
        public string UsuariosRut { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [ForeignKey("ClientesRut")]
        [InverseProperty("Mascota")]
        public virtual Cliente ClientesRutNavigation { get; set; }
        [ForeignKey("EspecieIdEspecie")]
        [InverseProperty("Mascota")]
        public virtual Especie EspecieIdEspecieNavigation { get; set; }
        [ForeignKey("RazaIdRaza")]
        [InverseProperty("Mascota")]
        public virtual Raza RazaIdRazaNavigation { get; set; }
        [ForeignKey("UsuariosRut")]
        [InverseProperty("Mascota")]
        public virtual Usuario UsuariosRutNavigation { get; set; }
        [InverseProperty("MascostaNumFichaNavigation")]
        public virtual ICollection<Atencion> Atencion { get; set; }
        [InverseProperty("MascostaNumFichaNavigation")]
        public virtual ICollection<Hora> Hora { get; set; }
        [InverseProperty("MascotaNumFichaNavigation")]
        public virtual ICollection<Peluqueria> Peluqueria { get; set; }
    }
}
