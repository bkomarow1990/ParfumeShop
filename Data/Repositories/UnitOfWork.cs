using ParfumeShop.Data;
using ParfumeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ParfumeDBContext context;// = new SalonDbContext()

        private Repository<Parfume> parfumeRepository;
        private Repository<Category> categoryRepository;
        private Repository<User> userRepository;

        public UnitOfWork(ParfumeDBContext context)
        {
            this.context = context;

            parfumeRepository = new Repository<Parfume>(context);
            categoryRepository = new Repository<Category>(context);
            userRepository = new Repository<User>(context);
        }

        public Repository<Parfume> ParfumeRepository => parfumeRepository;

        public Repository<Category> CategoryRepository => categoryRepository;

        public Repository<User> UserRepository => userRepository;

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
