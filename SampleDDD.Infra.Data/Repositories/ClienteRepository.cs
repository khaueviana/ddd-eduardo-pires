using SampleDDD.Domain.Entities;
using SampleDDD.Domain.Interfaces.Repositories;

namespace SampleDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
