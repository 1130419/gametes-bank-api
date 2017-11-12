using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GAM.GametesBank.Users.Models
{
    public class User
    {
        //[BsonId]
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public string Gender { get; set; }
        //public DateTime UpdatedOn { get; set; } = DateTime.Now;
        //public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}