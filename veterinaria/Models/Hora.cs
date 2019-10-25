using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("hora")]
    public partial class Hora
    {
        [Column("id_cita", TypeName = "int(11)")]
        public int IdCita { get; set; }
        [Required]
        [Column("Clientes_rut", TypeName = "varchar(15)")]
        public string ClientesRut { get; set; }
        [Column("Mascosta_num_ficha", TypeName = "int(11)")]
        public int MascostaNumFicha { get; set; }
        [Required]
        [Column("Usuarios_rut", TypeName = "varchar(15)")]
        public string UsuariosRut { get; set; }
        [Column("fecha", TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [Column("hora", TypeName = "varchar(10)")]
        public string Hora1 { get; set; }
        [Column("Consulta_id_consulta", TypeName = "int(11)")]
        public int? ConsultaIdConsulta { get; set; }
        [Column("motivo_consulta", TypeName = "varchar(300)")]
        public string MotivoConsulta { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }

        [ForeignKey("ClientesRut")]
        [InverseProperty("Hora")]
        public virtual Cliente ClientesRutNavigation { get; set; }
        [ForeignKey("ConsultaIdConsulta")]
        [InverseProperty("Hora")]
        public virtual Consulta ConsultaIdConsultaNavigation { get; set; }
        [ForeignKey("MascostaNumFicha")]
        [InverseProperty("Hora")]
        public virtual Mascota MascostaNumFichaNavigation { get; set; }
        [ForeignKey("UsuariosRut")]
        [InverseProperty("Hora")]
        public virtual Usuario UsuariosRutNavigation { get; set; }
    }
}
