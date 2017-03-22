namespace Daria.Repositories
{
    using MongoDB.Driver;
    using System.Configuration;

    public class MongoDbContext
    {
        private IMongoClient _dbClient;
        private IMongoDatabase _database;

        public MongoDbContext()
        {
            this._dbClient = new MongoClient(
                connectionString: ConfigurationManager.ConnectionStrings["Mongo"].ConnectionString);
            this._database = this._dbClient.GetDatabase("dariaDb");
        }
    }
}