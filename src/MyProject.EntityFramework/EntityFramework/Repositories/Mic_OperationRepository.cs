using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using MyProject.IRepositories;
using MyProject.Entities;

namespace MyProject.EntityFramework.Repositories
{
    public class Mic_OperationRepository : MyProjectRepositoryBase<Mic_Operation>, IMic_OperationRepository
    {
        public Mic_OperationRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }

        public IQueryable<Mic_Operation> ListOperation()
        {
            var mic_Operation = from mic_Operations in GetAll()
                                select mic_Operations;
            return mic_Operation;

        }

    }


}
