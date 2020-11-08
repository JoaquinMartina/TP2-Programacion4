using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

//Clase que se encargara de las conexiones a la BDD
namespace WebAppMovies_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext //Con esto utilizamos identidad de usuario y roles
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        //Para poder definir tablas con PK compartidas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AlumnoCatedra>().HasKey(x => new { x.AlumnoId, x.CatedraId });

            //Nombres y esquemas de la BDD al correr migraciones
            modelBuilder.Entity<IdentityUser>().ToTable("Usuarios","Seguridad");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles", "Seguridad");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UsuariosRoles", "Seguridad");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RolesClaims", "Seguridad");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UsuariosClaims", "Seguridad");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UsuariosLogin", "Seguridad");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UsuariosToken", "Seguridad");
        }

        //Tablas en plural - Modelos en singular
        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Localidad> Localidades { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Catedra> Catedra { get; set; }

        public DbSet<AlumnoCatedra> AlumnosCatedras { get; set; }

    }
}
