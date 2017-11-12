using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GAM.GametesBank.Users.Models;
using MongoDB.Driver;

namespace GAM.GametesBank.Users.Repository.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(string id);
        Task AddUser(User item);
        Task<DeleteResult> RemoveUser(string id);
        Task<UpdateResult> UpdateUser(string id, string body);

        // demo interface - full document update
        Task<ReplaceOneResult> UpdateUserDocument(string id, string body);

        // should be used with high cautious, only in relation with demo setup
        Task<DeleteResult> RemoveAllUsers();
    }
}
