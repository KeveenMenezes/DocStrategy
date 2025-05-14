using DocStrategy.Domain.Entities;
using DocStrategy.Domain.Interfaces.Adapters;

namespace DocStrategy.SegundoFornecedorAdapter;

public class SegundoFornecedorAdapter
    : ISegundoFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento) =>
        Task.FromResult("Segundo Fornecedor");
}
