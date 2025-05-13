namespace Application.Adapters;

public interface IPrimeiroFornecedor
{
    public Task<string> SolicitarDocumentoAsync(Documento documento);
}
