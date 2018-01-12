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
    public class Mic_NationalRepository : MyProjectRepositoryBase<Mic_National>, IMic_NationalRepository
    {
        public Mic_NationalRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
