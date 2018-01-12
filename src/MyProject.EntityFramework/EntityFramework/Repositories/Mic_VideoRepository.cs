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
    public class Mic_VideoRepository:MyProjectRepositoryBase<Mic_Video>,IMic_VideoRepository
    {
        public Mic_VideoRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider)
        { }
    }
}
