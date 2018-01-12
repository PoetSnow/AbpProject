using MyProject.Entities;
using Abp.EntityFramework;
using MyProject.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EntityFramework.Repositories
{
   public class Mic_CompanyRepository : MyProjectRepositoryBase<Mic_Company>, IMic_CompanyRepository
    {
        public Mic_CompanyRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider){}
    }
}
