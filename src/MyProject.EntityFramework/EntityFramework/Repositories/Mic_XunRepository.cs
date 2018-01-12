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
    public class Mic_XunRepository : MyProjectRepositoryBase<Mic_Xun>, IMic_XunRepository
    {
        public Mic_XunRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
