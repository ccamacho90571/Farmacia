using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            DoJob();
        }

        private static void DoJob()
        {
            var elInvocador = new Invocador();
            elInvocador.ConsultarRecetas();
        }
    }
}
