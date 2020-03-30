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
    public class Medico
    {
        [BsonId]
        public ObjectId id;

        [BsonElement("Codigo")]
        public int Codigo { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Especialidad")]
        public string Especialidad { get; set; }

        [BsonExtraElements] public BsonDocument Metadata { get; set; }

    }
}
