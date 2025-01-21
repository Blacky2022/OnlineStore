using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;

namespace StoreDAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreDbContext context;
        private readonly DbSet<User> dbSet;

        public UserRepository(StoreDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.dbSet = context.Set<User>();
        }

        public void Add(User entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            entity.Password = UserRepository.EncryptPassword(entity.Password);
            this.dbSet.Add(entity);
            this.context.SaveChanges();
        }

        public void Delete(User entity)
        {
            this.dbSet.Remove(entity);
            this.context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = this.dbSet.Find(id);
            if (entity != null)
            {
                this.dbSet.Remove(entity);
                this.context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            return this.dbSet.ToList();
        }

        public IEnumerable<User> GetAll(int pageNumber, int rowCount)
        {
            return this.dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public User GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void Update(User entity)
        {
            this.dbSet.Update(entity);
            this.context.SaveChanges();
        }

        private static string EncryptPassword(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = System.Security.Cryptography.SHA256.HashData(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
