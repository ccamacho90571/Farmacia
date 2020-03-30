using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Modelo.MisColecciones
{
    [BsonIgnoreExtraElements]
    public class Paciente
    {
        [BsonId]
        public ObjectId id;

        [BsonElement("Cedula")]
        public int Cedula { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Sintomas")]
        public string[] Sintomas { get; set; }

        [BsonElement("Diagnostico")]
        public string[] Diagnostico { get; set; }

        [BsonElement("Fecha")]
        public string Fecha { get; set; }

        [BsonExtraElements] public BsonDocument Metadata { get; set; }

    }
}
