using MongoDB.Driver;
using Farmacia.Modelo.MisColecciones;
using Farmacia.Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.ConsolaPruebas
{
    public class Invocador
    {
        private string parametro;
        public void ConsultarRecetas ()
        {
            CapturarInformacion();
            var listaAnimalitos = EjecutarConsulta(parametro);
            ImprimirListaDeAnimalitos(listaAnimalitos);
            ConsultarAnimalitosDueno();
        }
        
        public void ConsultarAnimalitosDueno()
        {
            CapturarInformacionDueno();
            var listaAnimalitos = EjecutarConsultaMedico(parametro);
            ImprimirListaDeAnimalitos(listaAnimalitos);
        }
        
        private void ImprimirListaDeAnimalitos(IList<Receta> listaAnimalitos)
        {
            if (listaAnimalitos.Count > 0)
            {
                foreach (var item in listaAnimalitos)
                {
                    Console.WriteLine("Nombre: {0}",item.Hospital);


                    
                    if (item.Medico != null)

                        Console.WriteLine("Médico: Código: {0} ||  Nombre: {1} || Especialidad: {2} ", item.Medico.Codigo, item.Medico.Nombre, item.Medico.Especialidad);
                    else
                        Console.WriteLine("El médico no se definió");

                    if (item.Paciente != null)
                    {
                        Console.WriteLine("Paciente: Cédula: {0} ||  Nombre: {1}   || Fecha de la consulta {2} ", item.Paciente.Cedula, item.Paciente.Nombre, item.Paciente.Fecha);
                        Console.WriteLine("Síntomas: ");
                        for (int x = 0; x < item.Paciente.Sintomas.Length; x++)
                        {
                            Console.WriteLine(item.Paciente.Sintomas[x]);
                        }

                    }
                    else
                    {
                        //Console.WriteLine("El paciente no se definió");
                    }
                        
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

        private IList<Modelo.MisColecciones.Receta> EjecutarConsultaMedico(string NombreHospital)
        {
            var elConsultante = new RecetaRep();
            var elResultado = elConsultante.ListarRecetasXMedico(NombreHospital);
            return elResultado;
        }


        private void CapturarInformacion()
        {
            Console.Write("Digite el nombre del hospital: ");
            parametro = Console.ReadLine();
            
        }

        
        private void CapturarInformacionDueno()
        {
            Console.Write("Digite el código del médico: ");
            parametro = Console.ReadLine();

        }
    }
}
