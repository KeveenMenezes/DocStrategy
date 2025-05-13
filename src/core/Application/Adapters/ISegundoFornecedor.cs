namespace Application.Adapters;

public interface ISegundoFornecedor
{
    public Task SolicitarDocumentoAsync(Documento documento);
}
