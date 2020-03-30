using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Farmacia.Negocio
{
    public class Conexion
    {
        public MongoClient ConnectWithoutAuthentication() 
        { 
            string connectionString = "mongodb://localhost:27017"; 
            MongoClient client = new MongoClient(connectionString);
            return client;
        }
        
        /*
        public MongoClient ConnectWithAuthentication(string dbName = "Farmacia", string userName = "", string password = "", string servername = "localhost", int portnumber = 27017)
        {
            //var credentials = MongoCredential.CreateCredential(dbName, "", "");
       
            MongoClientSettings clientSettings = new MongoClientSettings()
            {
                //Credentials = new[] { credentials
                //},
                Server = new MongoServerAddress(servername, portnumber)
            };
            MongoClient client = new MongoClient(clientSettings);
            return client;
        }
        
        */

        public MongoClient GetMongoClient(string hostName) 
        { 
            string connectionString = string.Format("mongodb://{0}:27017", hostName); 
            return new MongoClient(connectionString); 
        }

        public IMongoDatabase GetDatabaseReference(string hostName, string dbName) 
        { 
            MongoClient client = GetMongoClient(hostName); 
            IMongoDatabase database = client.GetDatabase(dbName); 
            return database; 
        }

        public IMongoDatabase CreateDatabase(string hostName, string databaseName, string collectionName) 
        { 
            MongoClient client = GetMongoClient(hostName); 
            IMongoDatabase database = client.GetDatabase(databaseName); 
            database.CreateCollection(collectionName); 
            return database; 
        }
    }
}
