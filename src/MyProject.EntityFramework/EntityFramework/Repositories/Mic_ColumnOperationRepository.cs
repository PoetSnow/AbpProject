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
  public  class Mic_ColumnOperationRepository : MyProjectRepositoryBase<Mic_ColumnOperation>, IMic_ColumnOperationRepository
    {
        public Mic_ColumnOperationRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
