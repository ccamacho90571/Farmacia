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
    public class Receta
    {
        [BsonId]
        public ObjectId id;

        [BsonElement("Hospital")]
        public string Hospital { get; set; }

        [BsonElement("Medico")]
        public Medico Medico { get; set; }

        [BsonElement("Paciente")]
        public Paciente Paciente { get; set; }

        [BsonElement("Medicamentos")]
        public Medicamento[] Medicamento { get; set; }

        [BsonExtraElements] public BsonDocument Metadata { get; set; }

    }
}
