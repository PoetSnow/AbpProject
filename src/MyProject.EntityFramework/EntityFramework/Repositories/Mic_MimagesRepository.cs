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
    public class Mic_MimagesRepository : MyProjectRepositoryBase<Mic_Mimages>, IMic_MimagesRepository
    {
        public Mic_MimagesRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
