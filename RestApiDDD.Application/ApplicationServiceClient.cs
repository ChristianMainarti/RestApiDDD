using RestApiDDD.Application.Dto;
using RestApiDDD.Application.Interfaces;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapper mapper;
        public ApplicationServiceCliente(IServiceClient serviceClient
                                       , IMapper mapper)
        {
            this.serviceClient = serviceClient;
            this.mapper = mapper;
        }
        public void Add(ClientDto clientDto)
        {
            var cliente = mapper.Map<Client>(clientDto);
            serviceClient.Add(cliente);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            var clientsDto = mapper.Map<IEnumerable<ClientDto>>(clients);

            return clientsDto;
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            var clienteDto = mapper.Map<ClientDto>(client);

            return clienteDto;
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapper.Map<Client>(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var cliente = mapper.Map<Client>(clientDto);
            serviceClient.Update(cliente);
        }
    }
}
