namespace PureAbstraction.WebApi.Mappers;

public abstract class CertidaoNascimentoMapper
{
    public static CertidaoCasamento CertidaoCasamentoMapperDtoParaDomain(
        CertidaoCasamentoDto certidaoCasamentoDto) => new()
        {
            Nome = certidaoCasamentoDto.Nome,
            NomeConjuge = certidaoCasamentoDto.NomeConjuge,
            DataCasamento = certidaoCasamentoDto.DataCasamento
        };
}
