using SampleDDD.Domain.Entities;
using SampleDDD.Domain.Interfaces.Services;
using SampleDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SampleDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
