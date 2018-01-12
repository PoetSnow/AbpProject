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
    public class Mic_SEOStatusRepository : MyProjectRepositoryBase<Mic_SEOStatus>, IMic_SEOStatusRepository
    {
        public Mic_SEOStatusRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
