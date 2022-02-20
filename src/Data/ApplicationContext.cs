using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine)
                          .UseSqlServer("Server=DESKTOP-B76722G\\SQLEXPRESS; Database=SobrescrevendoComportamentoEFCore; User ID=developer; Password=dev*10; Integrated Security=True;")
                          .ReplaceService<IQuerySqlGeneratorFactory, MySqlServerQuerySqlGeneratorFactory>()
                          .EnableSensitiveDataLogging();
        }
    }
}
