using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BusinessLogicLayer.InfrastructureService.IGeneric
{
    public interface IEntityRemover<T> where T : class
    {
        Task DeleteAsync(int id);
    }
}
