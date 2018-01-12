using Abp.Domain.Repositories;
using MyProject.Entities;
using System.Linq;


namespace MyProject.IRepositories
{
    public interface IMic_AdminRepository : IRepository<Mic_Admin>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        IQueryable<Mic_Admin> Login(string userName, string passWord);
    }
}
