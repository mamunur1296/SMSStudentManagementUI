using SMS.DataAccessLayer.Data;
using SMS.DataAccessLayer.InfrastructureDb.IRepository;
using SMS.DataAccessLayer.InfrastructureDb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccessLayer.InfrastructureDb
{
    public class UnitOfWorkDb : IIUnitOfWorkDb
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public IContactInfoDbRepo ContactInfoDbRepo { get; private set; }
        public UnitOfWorkDb(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            ContactInfoDbRepo = new ContactInfoDbRepo(applicationDbContext);
        }
        public async Task SaveAsync()
        {
            await  _applicationDbContext.SaveChangesAsync();
        }
    }
}
