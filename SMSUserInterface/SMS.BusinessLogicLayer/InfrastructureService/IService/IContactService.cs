using SMS.BusinessLogicLayer.InfrastructureService.IGeneric;
using SMS.BusinessObjectLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BusinessLogicLayer.InfrastructureService.IService
{
    public interface IContactService : IEntityCreator<ContactInfo> , IEntityReader<ContactInfo>
    {
    }
}
