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

        /// <summary>
        /// 查询子级栏目
        /// </summary>
        /// <param name="parent_id"></param>
        /// <returns></returns>
        public IQueryable<Mic_Type> ChildColumnList(int parent_id)
        {
            var list = from mic_Type in GetAll()
                       where mic_Type.parent_id == parent_id && mic_Type.display == true
                       orderby mic_Type.order_id ascending
                       select mic_Type;

            return list;
        }

        public IQueryable<Mic_Type> ChildColumnListAll(int parent_id)
        {
            var list = from mic_Type in GetAll()
                       where mic_Type.parent_id == parent_id 
                       orderby mic_Type.order_id ascending
                       select mic_Type;

            return list;
        }

        /// <summary>
        /// 判断当前节点是否有相同的栏目名称
        /// </summary>
        /// <param name="type_name"></param>
        /// <param name="parent_id"></param>
        /// <returns></returns>
        public IQueryable<Mic_Type> ValidateType(string type_name, int parent_id)
        {
            var list = from mic_Type in GetAll()
                       where mic_Type.parent_id == parent_id && mic_Type.type_name == type_name
                       select mic_Type;

            return list;
        }

        public int DeleteTypeList(string IdList)
        {
            int result = 0;
            using (MyProjectDbContext _content = new MyProjectDbContext())
            {
                result = _content.Database.ExecuteSqlCommand("Delete Mic_Type WHERE type_id IN(" + IdList + ")");
            }
            return result;
        }

    }
}
