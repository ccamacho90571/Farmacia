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
    public class Medicamento
    {
        [BsonId]
        public ObjectId id;

        [BsonElement("Producto")]
        public string Producto { get; set; }

        [BsonElement("Indicacion")]
        public string Indicacion { get; set; }

        [BsonElement("CantProducto")]
        public int CantProducto { get; set; }

        [BsonElement("DiasTratamiento")]
        public int DiasTratamiento { get; set; }

        [BsonElement("Meses")]
        public int Meses { get; set; }

        [BsonElement("FechaEntrega")]
        public string FechaEntrega { get; set; }

        [BsonExtraElements] public BsonDocument Metadata { get; set; }

    }
}
