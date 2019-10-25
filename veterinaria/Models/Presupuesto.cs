using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("presupuesto")]
    public partial class Presupuesto
    {
        [Column("id_presupuesto", TypeName = "int(11)")]
        public int IdPresupuesto { get; set; }
        [Required]
        [Column("Clientes_rut", TypeName = "varchar(15)")]
        public string ClientesRut { get; set; }
        [Column("fecha", TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [Column("cantidad", TypeName = "int(11)")]
        public int? Cantidad { get; set; }
        [Column("valor", TypeName = "varchar(50)")]
        public string Valor { get; set; }
        [Column("detalle", TypeName = "varchar(300)")]
        public string Detalle { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Column("Atención Veterinaria_num_atencion", TypeName = "int(11)")]
        public int? AtenciónVeterinariaNumAtencion { get; set; }
        [Column("Peluqueria_id_peluqueria", TypeName = "int(11)")]
        public int? PeluqueriaIdPeluqueria { get; set; }
        [Required]
        [Column("Usuarios_rut", TypeName = "varchar(15)")]
        public string UsuariosRut { get; set; }

        [ForeignKey("AtenciónVeterinariaNumAtencion")]
        [InverseProperty("Presupuesto")]
        public virtual Atencion AtenciónVeterinariaNumAtencionNavigation { get; set; }
        [ForeignKey("ClientesRut")]
        [InverseProperty("Presupuesto")]
        public virtual Cliente ClientesRutNavigation { get; set; }
        [ForeignKey("PeluqueriaIdPeluqueria")]
        [InverseProperty("Presupuesto")]
        public virtual Peluqueria PeluqueriaIdPeluqueriaNavigation { get; set; }
        [ForeignKey("UsuariosRut")]
        [InverseProperty("Presupuesto")]
        public virtual Usuario UsuariosRutNavigation { get; set; }
    }
}
