namespace Application.Adapters;

public interface ISegundoFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento);
}
