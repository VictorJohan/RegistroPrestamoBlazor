using Microsoft.EntityFrameworkCore;
using RegistroPrestamoBlazor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRegistroPrestamo.DALTest
{
    public class ContextoTest
    {
        public static Contexto _contexto { get; set; }

        public static Contexto GetContexto()
        {
            if(_contexto == null)
            {
                var option = new DbContextOptionsBuilder<Contexto>().
                    UseSqlite("Data Source=Data\\Prestamos.db").Options;
                _contexto = new Contexto(option);
            }

            return _contexto;
        }
    }
}
