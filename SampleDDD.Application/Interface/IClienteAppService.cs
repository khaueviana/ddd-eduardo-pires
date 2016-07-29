using SampleDDD.Domain.Entities;
using System.Collections.Generic;

namespace SampleDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
