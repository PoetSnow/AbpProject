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
    public class Mic_AdminRepository : MyProjectRepositoryBase<Mic_Admin>, IMic_AdminRepository
    {
        public Mic_AdminRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider) : base(dbContextProvider)
        { }
        public IQueryable<Mic_Admin> Login(string userName, string passWord)
        {
            var users = from mic_Admin in GetAll()
                        where mic_Admin.UserName == userName && mic_Admin.PassWord == passWord
                        select mic_Admin;
            return users;
        }
    }
}
