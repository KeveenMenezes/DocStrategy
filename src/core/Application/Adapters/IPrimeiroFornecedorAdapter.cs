namespace Application.Adapters;

public interface IPrimeiroFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento);
}
