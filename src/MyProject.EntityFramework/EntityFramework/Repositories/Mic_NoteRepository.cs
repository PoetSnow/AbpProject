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
    public class Mic_NoteRepository : MyProjectRepositoryBase<Mic_Note>, IMic_NoteRepository
    {
        public Mic_NoteRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
