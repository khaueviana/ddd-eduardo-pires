using SampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace SampleDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
