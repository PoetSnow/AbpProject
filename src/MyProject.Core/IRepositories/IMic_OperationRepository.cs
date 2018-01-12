using Abp.Domain.Repositories;
using MyProject.Entities;
using System.Linq;

namespace MyProject.IRepositories
{
    public interface IMic_OperationRepository : IRepository<Mic_Operation>
    {
        
        IQueryable<Mic_Operation> ListOperation();

    }
}
