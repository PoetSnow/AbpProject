using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Entities;
using MyProject.IRepositories;
using Abp.EntityFramework;

namespace MyProject.EntityFramework.Repositories
{
    public class Mic_ProjectsRepository : MyProjectRepositoryBase<Mic_Projects>, IMic_ProjectsRepository
    {
        public Mic_ProjectsRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
