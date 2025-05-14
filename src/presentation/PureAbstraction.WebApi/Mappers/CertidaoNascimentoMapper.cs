namespace PureAbstraction.WebApi.Mappers;

public abstract class CertidaoNascimentoMapper
{
    public static CertidaoNascimento CertidaoNascimentoMapperDtoParaDomain(
        CertidaoNascimentoDto certidaoNascimentoDto) => new()
        {
            Nome = certidaoNascimentoDto.Nome,
            NomeMae = certidaoNascimentoDto.NomeMae,
            DataNascimento = certidaoNascimentoDto.DataNascimento
        };
}
