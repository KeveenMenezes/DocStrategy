namespace PureAbstraction.WebApi.Mappers;

public abstract class CertidaoCasamentoMapper
{
    public static CertidaoCasamento CertidaoCasamentoMapperDtoParaDomain(
        CertidaoCasamentoDto certidaoCasamentoDto) => new()
        {
            Nome = certidaoCasamentoDto.Nome,
            NomeConjuge = certidaoCasamentoDto.NomeConjuge,
            DataCasamento = certidaoCasamentoDto.DataCasamento
        };
}
