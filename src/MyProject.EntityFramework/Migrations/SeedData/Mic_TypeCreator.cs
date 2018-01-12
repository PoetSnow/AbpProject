using MyProject.Entities;
using MyProject.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Migrations.SeedData
{
    public class Mic_TypeCreator
    {
        public static List<Mic_Type> TypeList { get; private set; }

        public readonly MyProjectDbContext _context;
        static Mic_TypeCreator()
        {
            TypeList = new List<Mic_Type>
            {
                new Mic_Type("系统开发",0,100,0,"","Left?typeid=1","",0,true),
                new Mic_Type("栏目管理",1,1,0,"","","",0,true),
                new Mic_Type("栏目列表",2,1,0,"","Menu/menu_status","",0,true),
                new Mic_Type("模板管理",2,2,0,"","Menu/type_list","",0,true)
            };
        }

        public Mic_TypeCreator(MyProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            Create_TypeList();
        }


        public void Create_TypeList()
        {
            foreach (var item in TypeList)
            {
                AddUserInfoIfNotExists(item);
            }
        }

        private void AddUserInfoIfNotExists(Mic_Type mic_Type)
        {
            if (_context.mic_Type.Any(l => l.type_name == mic_Type.type_name && l.parent_id == mic_Type.parent_id))
            {
                return;
            }

            _context.mic_Type.Add(mic_Type);

            _context.SaveChanges();
        }
    }
}
