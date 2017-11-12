using Microsoft.EntityFrameworkCore;
using GAM.GametesBank.Users.Data;
using GAM.GametesBank.Users.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace GAM.GametesBank.Users.Data
{
    public class UsersContext : DbContext
    {
        private readonly IMongoDatabase _database = null;

        public UsersContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<User> Users
        {
            get
            {
                return _database.GetCollection<User>("users");
            }
        }
    }
}