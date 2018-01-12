using Abp.EntityFramework;
using MyProject.Entities;
using MyProject.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EntityFramework.Repositories
{
   public class Mic_BooksRepository : MyProjectRepositoryBase<Mic_Books>, IMic_BooksRepository
    {
        public Mic_BooksRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
