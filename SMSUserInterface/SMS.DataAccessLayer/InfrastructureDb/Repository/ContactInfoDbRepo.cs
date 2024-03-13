using SMS.BusinessObjectLayer.Models;
using SMS.DataAccessLayer.Data;
using SMS.DataAccessLayer.InfrastructureDb.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccessLayer.InfrastructureDb.Repository
{
    public class ContactInfoDbRepo : GRepository<ContactInfo>, IContactInfoDbRepo
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public ContactInfoDbRepo(ApplicationDbContext applicationDbContext) : base(applicationDbContext) 
        {
            _ApplicationDbContext = applicationDbContext;
        }

        public void Update(ContactInfo contactInfo)
        {
            throw new NotImplementedException();
        }
    }
}
