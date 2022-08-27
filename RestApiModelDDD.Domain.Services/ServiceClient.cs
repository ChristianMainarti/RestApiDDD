using RestApiModelDDD.Domain.Core.Interfaces.Repositores;
using RestApiModelDDD.Domain.Entitys;
using RestApiModelDDD.Domain.Core.Interfaces.Services;


namespace RestApiModelDDD.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryCliente;

        public ServiceClient(IRepositoryClient repositoryClient)
            : base(repositoryClient)
        {
            this.repositoryCliente = repositoryClient;
        }
    }
}
