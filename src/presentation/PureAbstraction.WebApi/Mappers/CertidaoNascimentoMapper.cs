namespace PureAbstraction.WebApi.Mappers;

public static class CertidaoNascimentoMapper
{
    public static CertidaoNascimento MapearDocumentoDomain(
        this CertidaoNascimentoDto certidaoNascimentoDto) => new()
        {
            Nome = certidaoNascimentoDto.Nome,
            NomeMae = certidaoNascimentoDto.NomeMae,
            DataNascimento = certidaoNascimentoDto.DataNascimento
        };
}
