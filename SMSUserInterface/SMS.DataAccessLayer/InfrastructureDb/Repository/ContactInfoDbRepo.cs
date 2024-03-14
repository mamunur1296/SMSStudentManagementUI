using SMS.BusinessObjectLayer.Models;
using SMS.DataAccessLayer.Data;
using SMS.DataAccessLayer.InfrastructureDb.IRepository;

namespace SMS.DataAccessLayer.InfrastructureDb.Repository
{
    public class ContactInfoDbRepo : GRepository<ContactInfo>, IContactInfoDbRepo
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public ContactInfoDbRepo(ApplicationDbContext applicationDbContext) : base(applicationDbContext) 
        {
            _ApplicationDbContext = applicationDbContext;
        }

       //Extaned your Code and Methods 
    }
}
