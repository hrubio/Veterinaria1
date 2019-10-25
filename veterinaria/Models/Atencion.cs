using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace veterinaria.Models
{
    [Table("atencion")]
    public partial class Atencion
    {
        public Atencion()
        {
            Presupuesto = new HashSet<Presupuesto>();
        }

        [Column("num_atencion", TypeName = "int(11)")]
        public int NumAtencion { get; set; }
        [Column("num_ficha", TypeName = "varchar(30)")]
        public string NumFicha { get; set; }
        [Column("foto", TypeName = "tinyblob")]
        public byte[] Foto { get; set; }
        [Column("fecha_atencion", TypeName = "date")]
        public DateTime? FechaAtencion { get; set; }
        [Column("hora", TypeName = "varchar(10)")]
        public string Hora { get; set; }
        [Column("peso", TypeName = "varchar(10)")]
        public string Peso { get; set; }
        [Column("temperatura", TypeName = "varchar(10)")]
        public string Temperatura { get; set; }
        [Column("frecuencia_cardiaca", TypeName = "varchar(10)")]
        public string FrecuenciaCardiaca { get; set; }
        [Column("diagnostico", TypeName = "varchar(300)")]
        public string Diagnostico { get; set; }
        [Column("tratamiento", TypeName = "varchar(300)")]
        public string Tratamiento { get; set; }
        [Column("observaciones", TypeName = "varchar(400)")]
        public string Observaciones { get; set; }
        [Column("examenes")]
        public byte[] Examenes { get; set; }
        [Column("frecuecia_respiratoria", TypeName = "varchar(10)")]
        public string FrecueciaRespiratoria { get; set; }
        [Column("Mascosta_num_ficha", TypeName = "int(11)")]
        public int MascostaNumFicha { get; set; }
        [Column("Tipo_Atencion_id_tipo_atencion", TypeName = "int(11)")]
        public int TipoAtencionIdTipoAtencion { get; set; }
        [Required]
        [Column("Usuario_rut", TypeName = "varchar(15)")]
        public string UsuarioRut { get; set; }
        [Column("fecha_registro", TypeName = "date")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("Usuario_rut1", TypeName = "varchar(15)")]
        public string UsuarioRut1 { get; set; }

        [ForeignKey("MascostaNumFicha")]
        [InverseProperty("Atencion")]
        public virtual Mascota MascostaNumFichaNavigation { get; set; }
        [ForeignKey("TipoAtencionIdTipoAtencion")]
        [InverseProperty("Atencion")]
        public virtual TipoAtencion TipoAtencionIdTipoAtencionNavigation { get; set; }
        [ForeignKey("UsuarioRut1")]
        [InverseProperty("AtencionUsuarioRut1Navigation")]
        public virtual Usuario UsuarioRut1Navigation { get; set; }
        [ForeignKey("UsuarioRut")]
        [InverseProperty("AtencionUsuarioRutNavigation")]
        public virtual Usuario UsuarioRutNavigation { get; set; }
        [InverseProperty("AtenciónVeterinariaNumAtencionNavigation")]
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
    }
}
