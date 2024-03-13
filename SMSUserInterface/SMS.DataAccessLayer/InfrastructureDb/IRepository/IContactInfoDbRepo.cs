using SMS.BusinessObjectLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccessLayer.InfrastructureDb.IRepository
{
    public interface IContactInfoDbRepo : IGRepository<ContactInfo>
    {
        void Update(ContactInfo contactInfo);
    }
}
