namespace PureAbstraction.Domain.Interfaces.Adapters;

public interface IPrimeiroFornecedorAdapter
{
    public Task<string> SolicitarDocumentoAsync(Documento documento);
}
