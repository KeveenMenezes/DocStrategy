namespace PureAbstraction.WebApi.Dtos.Documentos;

public class CertidaoCasamentoDto : DocumentoDto
{
    
    [Required]
    public required string Nome { get; set; }

    [Required]
    public required string NomeConjuge { get; set; }

    [Required]
    public required DateTime DataCasamento { get; set; }
}
