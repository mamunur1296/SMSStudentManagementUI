using SMS.BusinessLogicLayer.InfrastructureService.IService;
using SMS.BusinessLogicLayer.InfrastructureService.Service;
using SMS.DataAccessLayer.InfrastructureDb;

namespace SMS.BusinessLogicLayer.InfrastructureService
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        //private readonly IIUnitOfWorkDb _unitOfWorkDb;
        public IContactService ContactService { get; private set; }
        public UnitOfWorkService(IIUnitOfWorkDb unitOfWorkDb)
        {
            //_unitOfWorkDb = unitOfWorkDb;
            ContactService = new ContactService(unitOfWorkDb);
        }
    }
}
