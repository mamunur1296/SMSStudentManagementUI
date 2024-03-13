using SMS.BusinessLogicLayer.InfrastructureService.IService;
using SMS.BusinessObjectLayer.Models;
using SMS.DataAccessLayer.InfrastructureDb;
namespace SMS.BusinessLogicLayer.InfrastructureService.Service
{
    public class ContactService : IContactService
    {
        private readonly IIUnitOfWorkDb _iunitOfWorkDb;

        public ContactService(IIUnitOfWorkDb iunitOfWorkDb)
        {
            _iunitOfWorkDb = iunitOfWorkDb;
        }

        public async Task CreateAsync(ContactInfo model) 
        {
            await _iunitOfWorkDb.ContactInfoDbRepo.AddAsync(model);
            await _iunitOfWorkDb.SaveAsync();
        }

        public async Task<IEnumerable<ContactInfo>> GetAllAsync()
        {
            return await _iunitOfWorkDb.ContactInfoDbRepo.GetAllAsync();
        }

        public Task<ContactInfo> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
