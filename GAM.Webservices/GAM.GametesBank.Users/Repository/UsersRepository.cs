using System;
using System.Collections.Generic;
using System.Linq;
using GAM.GametesBank.Users.Models;
using GAM.GametesBank.Users.Data;
//using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using GAM.GametesBank.Users.Repository.Interfaces;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Options;

namespace GAM.GametesBank.Users.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersContext _context = null;

        public UsersRepository(IOptions<Settings> settings)
        {
            _context = new UsersContext(settings);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.Find(_ => true).ToListAsync();
        }

        public async Task<User> GetUser(string id)
        {
            var filter = Builders<User>.Filter.Eq("Id", id);
            return await _context.Users
                                 .Find(filter)
                                 .FirstOrDefaultAsync();
        }

        public async Task AddUser(User item)
        {
            await _context.Users.InsertOneAsync(item);
        }

        public async Task<DeleteResult> RemoveUser(string id)
        {
            return await _context.Users.DeleteOneAsync(
                         Builders<User>.Filter.Eq("Id", id));
        }

        public async Task<UpdateResult> UpdateUser(string id, string body)
        {
            throw new NotImplementedException();
        }

        public async Task<ReplaceOneResult> UpdateUser(string id, User item)
        {
            return await _context.Users
                                 .ReplaceOneAsync(n => n.Id.Equals(id)
                                                     , item
                                                     , new UpdateOptions { IsUpsert = true });
        }

        public async Task<DeleteResult> RemoveAllUsers()
        {
            return await _context.Users.DeleteManyAsync(new BsonDocument());
        }

        public Task<ReplaceOneResult> UpdateUserDocument(string id, string body)
        {
            throw new NotImplementedException();
        }
    }
}