using MongoDB.Bson;
using MongoDB.Driver;
using Farmacia.Modelo.MisColecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Negocio.Repositorio
{
    public class RecetaRep
    {
        private const string _collName = "Recetas";
        private const string _dbName = "Farmacia";

        private IMongoCollection<Receta> ObtenerColeccionRecetas()
        {
            var laConexion = new Conexion();
            var db = laConexion.GetDatabaseReference("localhost", _dbName);
            var collection = db.GetCollection<Receta>(_collName);
            return collection;
        }

        public IList<Receta> ListarTodos
            (string nombreDelHost, string dbName)
        {
            var elCliente = new Conexion();
            var laBaseDeDatos = elCliente.GetDatabaseReference(nombreDelHost, dbName);
            var laColeccion = laBaseDeDatos.GetCollection<BsonDocument>("Recetas");
            var filter = new BsonDocument();
            var elResultado = laColeccion.Find<BsonDocument>(filter);
            IList<Receta> laLista = new List<Receta>();
            return laLista;
        }

        public IList<Receta> ListarRecetasXHospital(string NombreHospital)
        {
            var Recetas = ObtenerColeccionRecetas();
         
            var expresssionFilter = Builders<Receta>.Filter.Eq(x => x.Hospital, NombreHospital);
            var result = Recetas.Find(expresssionFilter).ToList();
            return result;
        }

        public IList<Receta> ListarRecetasXMedico(string NombreMedico)
        {
            var Recetas = ObtenerColeccionRecetas();
            
            var expresssionFilter = Builders<Receta>.Filter.Eq(x => x.Medico.Nombre, NombreMedico);
            var result = Recetas.Find(expresssionFilter).ToList();
            return result;
        }

        public IList<Receta> ListarRecetasXPaciente(string NombrePaciente)
        {
            var Recetas = ObtenerColeccionRecetas();

            var expresssionFilter = Builders<Receta>.Filter.Eq(x => x.Paciente.Nombre, NombrePaciente);
            var result = Recetas.Find(expresssionFilter).ToList();
            return result;
        }

        public IList<Receta> ListarRecetasXEspecialidad(string NombreEspecialidad)
        {
            var Recetas = ObtenerColeccionRecetas();

            var expresssionFilter = Builders<Receta>.Filter.Eq(x => x.Medico.Especialidad, NombreEspecialidad);
            var result = Recetas.Find(expresssionFilter).ToList();
            return result;
        }

    }
}
