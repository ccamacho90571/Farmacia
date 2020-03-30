using MongoDB.Driver;
using Farmacia.Modelo.MisColecciones;
using Farmacia.Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.PruebaConsola
{
    public class Invocador
    {
        private string nombreAnimalito;
        public void ConsultarRecetas ()
        {
            CapturarInformacion();
            var listaAnimalitos = EjecutarConsulta(nombreAnimalito);
            ImprimirListaDeAnimalitos(listaAnimalitos);
            ConsultarAnimalitosDueno();
        }
        
        public void ConsultarAnimalitosDueno()
        {
            CapturarInformacionDueno();
            var listaAnimalitos = EjecutarConsultaDueno(nombreAnimalito);
            ImprimirListaDeAnimalitos(listaAnimalitos);
        }
        
        private void ImprimirListaDeAnimalitos(IList<Receta> listaAnimalitos)
        {
            if (listaAnimalitos.Count > 0)
            {
                foreach (var item in listaAnimalitos)
                {
                    Console.WriteLine("Nombre: {0}",item.Hospital);

                    /*
                    if (item.dueno != null)

                        Console.WriteLine("Dueños: Nombre: {0} - email {1}", item.dueno.Nombre, item.dueno.Email);
                    else
                        Console.WriteLine("Dueño: Desconocido");*/
                }
            }
            else
                Console.WriteLine("No se encontraron recetas.");
            ;
            Console.ReadLine();
        }

        private IList<Modelo.MisColecciones.Receta> EjecutarConsulta(string NombreHospital)
        {
            var elConsultante = new RecetaRep();
            var elResultado = elConsultante.ListarRecetasXHospital(NombreHospital);
            return elResultado;
        }

        private IList<Modelo.MisColecciones.Receta> EjecutarConsultaDueno(string NombreHospital)
        {
            var elConsultante = new RecetaRep();
            var elResultado = elConsultante.ListarRecetasXMedico(NombreHospital);
            return elResultado;
        }


        private void CapturarInformacion()
        {
            Console.Write("Digite el nombre del animalito: ");
            nombreAnimalito = Console.ReadLine();
            
        }

        
        private void CapturarInformacionDueno()
        {
            Console.Write("Digite el nombre del dueño: ");
            nombreAnimalito = Console.ReadLine();

        }
    }
}
