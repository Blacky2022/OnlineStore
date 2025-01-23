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
    public class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly StoreDbContext context;
        private readonly DbSet<CustomerOrder> dbSet;

        public CustomerOrderRepository(StoreDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.dbSet = context.Set<CustomerOrder>();
        }

        public void Add(CustomerOrder entity)
        {
            this.dbSet.Add(entity);
            this.context.SaveChanges();
        }

        public void Delete(CustomerOrder entity)
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

        public IEnumerable<CustomerOrder> GetAll()
        {
            return this.dbSet.ToList();
        }

        public IEnumerable<CustomerOrder> GetAll(int pageNumber, int rowCount)
        {
            return this.dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        public CustomerOrder GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void Update(CustomerOrder entity)
        {
            this.dbSet.Update(entity);
            this.context.SaveChanges();
        }
    }
}
