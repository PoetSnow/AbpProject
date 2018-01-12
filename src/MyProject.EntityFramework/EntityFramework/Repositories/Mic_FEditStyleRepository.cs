using MyProject.Entities;
using MyProject.IRepositories;
using Abp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EntityFramework.Repositories
{
   public class Mic_FEditStyleRepository:MyProjectRepositoryBase<Mic_FEditStyle>, IMic_FEditStyleRepository
    {
        public Mic_FEditStyleRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
