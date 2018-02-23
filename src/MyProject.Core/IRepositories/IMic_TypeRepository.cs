using Abp.Domain.Repositories;
using MyProject.Entities;
using System.Linq;

namespace MyProject.IRepositories
{
    public interface IMic_TypeRepository:IRepository<Mic_Type>
    {
        IQueryable<Mic_Type> ChildColumnList(int parent_id);

        IQueryable<Mic_Type> ChildColumnListAll(int parent_id);



        IQueryable<Mic_Type> ValidateType(string type_name, int parent_id);

        int DeleteTypeList(string IdList);

    }
}

