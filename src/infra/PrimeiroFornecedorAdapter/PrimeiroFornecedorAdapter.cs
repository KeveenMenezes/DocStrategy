using PureAbstraction.Domain.Entities;
using PureAbstraction.Domain.Interfaces.Adapters;

namespace PureAbstraction.PrimeiroFornecedorAdapter;

public class PrimeiroFornecedorAdapter
    : IPrimeiroFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento) =>
        Task.FromResult("Primeiro Fornecedor");
}
