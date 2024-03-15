using SMS.BusinessLogicLayer.InfrastructureService.IGeneric;


namespace SMS.BusinessLogicLayer.InfrastructureService.IService
{
    public interface ICommonServices<T> : IEntityCreator<T> , IEntityReader<T> where T : class
    {
        // Add any Common Methods 
    }
}
