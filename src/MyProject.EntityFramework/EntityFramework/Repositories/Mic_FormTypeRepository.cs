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
    public class Mic_FormTypeRepository : MyProjectRepositoryBase<Mic_FormType>, IMic_FormTypeRepository
    {
        public Mic_FormTypeRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
