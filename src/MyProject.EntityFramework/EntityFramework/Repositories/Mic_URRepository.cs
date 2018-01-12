using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using MyProject.Entities;
using MyProject.IRepositories;

namespace MyProject.EntityFramework.Repositories
{
    public class Mic_URRepository : MyProjectRepositoryBase<Mic_UR>, IMic_URRepository
    {
        public Mic_URRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
