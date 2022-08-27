using RestApiDDD.Application.Dto;
using System.Collections.Generic;

namespace RestApiDDD.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDto clienteDto);

        void Update(ClientDto clienteDto);

        void Remove(ClientDto clienteDto);

        IEnumerable<ClientDto> GetAll();

        ClientDto GetById(int id);
    }
}
