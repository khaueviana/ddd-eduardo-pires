using SampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace SampleDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
