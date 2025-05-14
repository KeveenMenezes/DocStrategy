using PureAbstraction.Domain.Entities;
using PureAbstraction.Domain.Interfaces.Adapters;

namespace PureAbstraction.SegundoFornecedorAdapter;

public class SegundoFornecedorAdapter
    : ISegundoFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento) =>
        Task.FromResult("Segundo Fornecedor");
}
