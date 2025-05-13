namespace Domain.Entities;

public abstract class Entity
{
    [Key]
    public int Id { get; set; }

    public DateTime DataCadastro { get; private set; } = DateTime.Now;

    public DateTime? DataAlteracao { get; protected set; }

    public void AtualizarDataAlteracao()
    {
        DataAlteracao = DateTime.Now;
    }
}
