using Microsoft.EntityFrameworkCore;
using Proyecto_Taqueria.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Taqueria.Context
{
    public class AplicationdbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server = localhost; database = proyecto_Taqueria; user= root; pasword= ");
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}