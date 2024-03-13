using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BusinessLogicLayer.InfrastructureService.IGeneric
{
    public interface IEntityUpdater<T> where T : class
    {
        Task<T> UpdateAsync(T model, int id);
    }
}
