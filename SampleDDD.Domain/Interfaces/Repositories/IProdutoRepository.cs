using SampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace SampleDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}