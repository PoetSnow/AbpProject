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
    public class Mic_TypeRepository : MyProjectRepositoryBase<Mic_Type>, IMic_TypeRepository
    {
        public Mic_TypeRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider) { }


        public IQueryable<Mic_Type> ChildColumnList(int parent_id)
        {
            var list = from mic_Type in GetAll()
                       where mic_Type.parent_id == parent_id && mic_Type.display == true orderby mic_Type.order_id ascending
                       select mic_Type;

            return list;
        }
    }
}
