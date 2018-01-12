using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.EntityFramework;
using MyProject.Entities;

namespace MyProject.Migrations.SeedData
{
    public class Mic_AdminCreator
    {


        public static List<Mic_Admin> UserList { get; private set; }

        public readonly MyProjectDbContext _context;
        static Mic_AdminCreator()
        {
            UserList = new List<Mic_Admin>
            {
                new Mic_Admin("manage","1",DateTime.Now),
                 new Mic_Admin("admin","1",DateTime.Now)
            };
        }

        public Mic_AdminCreator(MyProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateMic_Admin();
        }


        public void CreateMic_Admin()
        {
            foreach (var item in UserList)
            {
                AddUserInfoIfNotExists(item);
            }
        }

        private void AddUserInfoIfNotExists(Mic_Admin mic_Admin)
        {
            if (_context.Mic_Admin.Any(l => l.UserName == mic_Admin.UserName && l.PassWord == mic_Admin.PassWord))
            {
                return;
            }

            _context.Mic_Admin.Add(mic_Admin);

            _context.SaveChanges();
        }
    }
}
