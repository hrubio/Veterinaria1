using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("peluqueria")]
    public partial class Peluqueria
    {
        public Peluqueria()
        {
            Presupuesto = new HashSet<Presupuesto>();
        }

        [Column("id_peluqueria", TypeName = "int(11)")]
        public int IdPeluqueria { get; set; }
        [Column("Mascota_num_ficha", TypeName = "int(11)")]
        public int MascotaNumFicha { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }
        [Column("fecha_ingreso", TypeName = "date")]
        public DateTime? FechaIngreso { get; set; }
        [Column("hora_ingreso", TypeName = "varchar(10)")]
        public string HoraIngreso { get; set; }
        [Column("hora_retiro", TypeName = "varchar(10)")]
        public string HoraRetiro { get; set; }
        [Column("responsable", TypeName = "varchar(100)")]
        public string Responsable { get; set; }
        [Column("valor", TypeName = "varchar(50)")]
        public string Valor { get; set; }
        [Column("observacion", TypeName = "varchar(300)")]
        public string Observacion { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [ForeignKey("MascotaNumFicha")]
        [InverseProperty("Peluqueria")]
        public virtual Mascota MascotaNumFichaNavigation { get; set; }
        [ForeignKey("UsuarioRut")]
        [InverseProperty("Peluqueria")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("PeluqueriaIdPeluqueriaNavigation")]
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
    }
}
