namespace Domain.Interfaces.Adapters;

public interface ISegundoFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento);
}
