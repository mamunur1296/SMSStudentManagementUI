using SMS.DataAccessLayer.InfrastructureDb.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccessLayer.InfrastructureDb
{
    public interface IIUnitOfWorkDb
    {
        IContactInfoDbRepo ContactInfoDbRepo { get; }
        Task SaveAsync();
    }
}
