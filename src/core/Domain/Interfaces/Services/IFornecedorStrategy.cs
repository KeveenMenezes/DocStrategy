namespace PureAbstraction.Domain.Interfaces.Services;

public interface IFornecedorStrategy
{
    public List<TipoDocumento> TipoDocumentos { get; }
    public Task<string> ObterDocumentoForcedorAsync(Documento documento);
}
