using RestApiModelDDD.Domain.Core.Interfaces.Repositores;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Entitys;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}
