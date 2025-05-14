namespace DocStrategy.WebApi.Mappers;

public static class CertidaoCasamentoMapper
{
    public static CertidaoCasamento MapearDocumentoDomain(
        this CertidaoCasamentoDto certidaoCasamentoDto) => new()
        {
            Nome = certidaoCasamentoDto.Nome,
            NomeConjuge = certidaoCasamentoDto.NomeConjuge,
            DataCasamento = certidaoCasamentoDto.DataCasamento
        };
}
