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
   public class Mic_GetJobRepository:MyProjectRepositoryBase<Mic_GetJob>, IMic_GetJobRepository
    {
        public Mic_GetJobRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider):base(dbContextProvider) { }
    }
}
