using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagnosticListener.AllListeners.Subscribe(new MyInterceptorListener());

            using ApplicationContext db = new ApplicationContext();
            db.Database.EnsureCreated();

            //string sql = db.Departamentos.Where(departamento => departamento.Id > 0)
            //                             .ToQueryString();

            _ = db.Departamentos.Where(departamento => departamento.Id > 0)
                                .ToArray();

            //Console.WriteLine(sql);
        }
    }
}
