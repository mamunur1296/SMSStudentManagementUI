using SMS.BusinessLogicLayer.InfrastructureService.IService;
using SMS.DataAccessLayer.InfrastructureDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BusinessLogicLayer.InfrastructureService.Service
{
    public class CommonServices<T> : ICommonServices<T> where T : class
    {
        private readonly IIUnitOfWorkDb _iunitOfWorkDb;

        public CommonServices(IIUnitOfWorkDb iunitOfWorkDb)
        {
            _iunitOfWorkDb = iunitOfWorkDb;
        }

        public Task CreateAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
