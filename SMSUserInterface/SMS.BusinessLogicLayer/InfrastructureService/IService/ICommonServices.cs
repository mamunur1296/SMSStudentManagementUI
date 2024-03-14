using SMS.BusinessLogicLayer.InfrastructureService.IGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BusinessLogicLayer.InfrastructureService.IService
{
    public interface ICommonServices<T> : IEntityCreator<T> , IEntityReader<T> where T : class
    {
    }
}
