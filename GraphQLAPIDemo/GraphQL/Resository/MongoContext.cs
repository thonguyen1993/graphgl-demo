using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAPIDemo.GraphQL.Resository
{


    public  class MongoContext : IMongoContext
    {
        public MongoContext(IMongoDbSettings connectionSetting)
        {
            var client = new MongoClient(connectionSetting.ConnectionString);
            Database = client.GetDatabase(connectionSetting.DatabaseName);
        }

        public IMongoDatabase Database { get; }
    }
}
