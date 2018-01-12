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
    public class Mic_JurisdictionRepository : MyProjectRepositoryBase<Mic_Jurisdiction>, IMic_JurisdictionRepository
    {
        public Mic_JurisdictionRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
