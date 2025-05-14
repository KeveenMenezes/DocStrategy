using DocStrategy.Domain.Entities;
using DocStrategy.Domain.Interfaces.Adapters;

namespace DocStrategy.PrimeiroFornecedorAdapter;

public class PrimeiroFornecedorAdapter
    : IPrimeiroFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento) =>
        Task.FromResult("Primeiro Fornecedor");
}
