using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace veterinaria.Models
{
    public partial class mydbContext : DbContext
    {
        public mydbContext()
        {
        }

        public mydbContext(DbContextOptions<mydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Atencion> Atencion { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Especie> Especie { get; set; }
        public virtual DbSet<Hora> Hora { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<Peluqueria> Peluqueria { get; set; }
        public virtual DbSet<Presupuesto> Presupuesto { get; set; }
        public virtual DbSet<Raza> Raza { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoAtencion> TipoAtencion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=Inacap.2019;database=mydb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Atencion>(entity =>
            {
                entity.HasKey(e => e.NumAtencion)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MascostaNumFicha)
                    .HasName("fk_Atención Veterinaria_Mascosta1_idx");

                entity.HasIndex(e => e.TipoAtencionIdTipoAtencion)
                    .HasName("fk_Atencion_Tipo_Atencion1_idx");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Atencion_Usuario1_idx");

                entity.HasIndex(e => e.UsuarioRut1)
                    .HasName("fk_Atencion_Usuario2_idx");

                entity.HasOne(d => d.MascostaNumFichaNavigation)
                    .WithMany(p => p.Atencion)
                    .HasForeignKey(d => d.MascostaNumFicha)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Atención Veterinaria_Mascosta1");

                entity.HasOne(d => d.TipoAtencionIdTipoAtencionNavigation)
                    .WithMany(p => p.Atencion)
                    .HasForeignKey(d => d.TipoAtencionIdTipoAtencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Atencion_Tipo_Atencion1");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.AtencionUsuarioRutNavigation)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Atencion_Usuario1");

                entity.HasOne(d => d.UsuarioRut1Navigation)
                    .WithMany(p => p.AtencionUsuarioRut1Navigation)
                    .HasForeignKey(d => d.UsuarioRut1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Atencion_Usuario2");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Rut)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Cliente_Usuario1_idx");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Cliente_Usuario1");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.HasKey(e => e.IdConsulta)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Consulta_Usuario1_idx");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Consulta_Usuario1");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<Especie>(entity =>
            {
                entity.HasKey(e => e.IdEspecie)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Especie_Usuario1_idx");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.Especie)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Especie_Usuario1");
            });

            modelBuilder.Entity<Hora>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ClientesRut)
                    .HasName("fk_Hora_Clientes1_idx");

                entity.HasIndex(e => e.ConsultaIdConsulta)
                    .HasName("fk_Hora_Consulta1_idx");

                entity.HasIndex(e => e.MascostaNumFicha)
                    .HasName("fk_Hora_Mascosta1_idx");

                entity.HasIndex(e => e.UsuariosRut)
                    .HasName("fk_Hora_Usuarios1_idx");

                entity.HasOne(d => d.ClientesRutNavigation)
                    .WithMany(p => p.Hora)
                    .HasForeignKey(d => d.ClientesRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Hora_Clientes1");

                entity.HasOne(d => d.ConsultaIdConsultaNavigation)
                    .WithMany(p => p.Hora)
                    .HasForeignKey(d => d.ConsultaIdConsulta)
                    .HasConstraintName("fk_Hora_Consulta1");

                entity.HasOne(d => d.MascostaNumFichaNavigation)
                    .WithMany(p => p.Hora)
                    .HasForeignKey(d => d.MascostaNumFicha)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Hora_Mascosta1");

                entity.HasOne(d => d.UsuariosRutNavigation)
                    .WithMany(p => p.Hora)
                    .HasForeignKey(d => d.UsuariosRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Hora_Usuarios1");
            });

            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.HasKey(e => e.NumFicha)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ClientesRut)
                    .HasName("fk_Mascosta_Clientes1_idx");

                entity.HasIndex(e => e.EspecieIdEspecie)
                    .HasName("fk_Mascota_Especie1_idx");

                entity.HasIndex(e => e.RazaIdRaza)
                    .HasName("fk_Mascota_Raza1_idx");

                entity.HasIndex(e => e.UsuariosRut)
                    .HasName("fk_Mascota_Usuarios1_idx");

                entity.HasOne(d => d.ClientesRutNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.ClientesRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Mascosta_Clientes1");

                entity.HasOne(d => d.EspecieIdEspecieNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.EspecieIdEspecie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Mascota_Especie1");

                entity.HasOne(d => d.RazaIdRazaNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.RazaIdRaza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Mascota_Raza1");

                entity.HasOne(d => d.UsuariosRutNavigation)
                    .WithMany(p => p.Mascota)
                    .HasForeignKey(d => d.UsuariosRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Mascota_Usuarios1");
            });

            modelBuilder.Entity<Peluqueria>(entity =>
            {
                entity.HasKey(e => e.IdPeluqueria)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.MascotaNumFicha)
                    .HasName("fk_Peluqueria_Mascota1_idx");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Peluqueria_Usuario1_idx");

                entity.HasOne(d => d.MascotaNumFichaNavigation)
                    .WithMany(p => p.Peluqueria)
                    .HasForeignKey(d => d.MascotaNumFicha)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Peluqueria_Mascota1");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.Peluqueria)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Peluqueria_Usuario1");
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.HasKey(e => e.IdPresupuesto)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.AtenciónVeterinariaNumAtencion)
                    .HasName("fk_Presupuesto_Atención Veterinaria1_idx");

                entity.HasIndex(e => e.ClientesRut)
                    .HasName("fk_Presupuesto_Clientes1_idx");

                entity.HasIndex(e => e.PeluqueriaIdPeluqueria)
                    .HasName("fk_Presupuesto_Peluqueria1_idx");

                entity.HasIndex(e => e.UsuariosRut)
                    .HasName("fk_Presupuesto_Usuarios1_idx");

                entity.HasOne(d => d.AtenciónVeterinariaNumAtencionNavigation)
                    .WithMany(p => p.Presupuesto)
                    .HasForeignKey(d => d.AtenciónVeterinariaNumAtencion)
                    .HasConstraintName("fk_Presupuesto_Atención Veterinaria1");

                entity.HasOne(d => d.ClientesRutNavigation)
                    .WithMany(p => p.Presupuesto)
                    .HasForeignKey(d => d.ClientesRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Presupuesto_Clientes1");

                entity.HasOne(d => d.PeluqueriaIdPeluqueriaNavigation)
                    .WithMany(p => p.Presupuesto)
                    .HasForeignKey(d => d.PeluqueriaIdPeluqueria)
                    .HasConstraintName("fk_Presupuesto_Peluqueria1");

                entity.HasOne(d => d.UsuariosRutNavigation)
                    .WithMany(p => p.Presupuesto)
                    .HasForeignKey(d => d.UsuariosRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Presupuesto_Usuarios1");
            });

            modelBuilder.Entity<Raza>(entity =>
            {
                entity.HasKey(e => e.IdRaza)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Raza_Usuario1_idx");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.Raza)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Raza_Usuario1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UsuariosRut)
                    .HasName("fk_Roles_Usuarios1_idx");

                entity.HasOne(d => d.UsuariosRutNavigation)
                    .WithMany(p => p.Rol)
                    .HasForeignKey(d => d.UsuariosRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Roles_Usuarios1");
            });

            modelBuilder.Entity<TipoAtencion>(entity =>
            {
                entity.HasKey(e => e.IdTipoAtencion)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.UsuarioRut)
                    .HasName("fk_Tipo_Atencion_Usuario1_idx");

                entity.HasOne(d => d.UsuarioRutNavigation)
                    .WithMany(p => p.TipoAtencion)
                    .HasForeignKey(d => d.UsuarioRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tipo_Atencion_Usuario1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Rut)
                    .HasName("PRIMARY");
            });
        }
    }
}
