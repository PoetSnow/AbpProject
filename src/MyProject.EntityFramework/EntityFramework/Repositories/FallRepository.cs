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
    public class FallRepository : MyProjectRepositoryBase<Fall>, IFallRepository
    {
        public FallRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
