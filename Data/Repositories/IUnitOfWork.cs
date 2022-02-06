using ParfumeShop.Data;
using ParfumeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Parfume> ParfumeRepository { get; }
        Repository<Category> CategoryRepository { get; }
        Repository<User> UserRepository { get; }
        void Save();
    }
}
