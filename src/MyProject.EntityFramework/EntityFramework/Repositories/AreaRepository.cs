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
    public class AreaRepository :MyProjectRepositoryBase<Mic_Area>, IAreaRepository
    {
        public AreaRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
