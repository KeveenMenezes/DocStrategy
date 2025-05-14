using Domain.Entities;
using Domain.Interfaces.Adapters;

namespace PrimeiroFornecedorAdapter;

public class PrimeiroFornecedorAdapter
    : IPrimeiroFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento) =>
        Task.FromResult("Primeiro Fornecedor");
}
