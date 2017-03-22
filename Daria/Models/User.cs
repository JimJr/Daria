namespace Daria.Models
{
    using MongoDB.Bson;

    public class User
    {
        public ObjectId _id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}