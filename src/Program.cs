using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();

            string sql = db.Departamentos.Where(departamento => departamento.Id > 0)
                                         .ToQueryString();

            Console.WriteLine(sql);
        }
    }
}
