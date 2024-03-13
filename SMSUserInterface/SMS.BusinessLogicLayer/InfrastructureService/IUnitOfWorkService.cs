using SMS.BusinessLogicLayer.InfrastructureService.IService;


namespace SMS.BusinessLogicLayer.InfrastructureService
{
    public interface IUnitOfWorkService
    {
        IContactService ContactService { get; }
    }
}
