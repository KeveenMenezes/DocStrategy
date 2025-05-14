using Domain.Entities;
using Domain.Interfaces.Adapters;

namespace SegundoFornecedorAdapter;

public class SegundoFornecedorAdapter
    : ISegundoFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento) =>
        Task.FromResult("Segundo Fornecedor");
}
