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
  public  class Mic_JobTypeRepository:MyProjectRepositoryBase<Mic_JobType>, IMic_JobTypeRepository
    {
        public Mic_JobTypeRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider):base(dbContextProvider) { }
    }
}
