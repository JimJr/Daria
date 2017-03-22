namespace Daria.Repositories
{
    using System;
    using Daria.Models;
    using MongoDB.Driver;
    using MongoDB.Bson;
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

        public async User GetUser(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("UserId cannot be null or empty.");
            }

            var users = this._database.GetCollection<BsonDocument>("users");
            if(users == null)
            {
                return null;
            }

            var filter = Builders<BsonDocument>.Filter.Eq("userId", userId);
            var result = await users.Find(filter).ToListAsync();

            foreach (var doc in result)
            {
                foreach (var el in doc.Elements)
                {                    
                }
            }
        }
    }
}