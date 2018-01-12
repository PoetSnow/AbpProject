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
    public class Mic_RoleRepository : MyProjectRepositoryBase<Mic_Role>, IMic_RoleRepository
    {
        public Mic_RoleRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
