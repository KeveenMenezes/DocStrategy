namespace DocStrategy.Domain.Interfaces.Services;

public interface IDocumentoContext
{
    public Task<string> SolicitarDocumentoAsync(Documento documento);
}
