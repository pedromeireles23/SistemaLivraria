public interface IEmprestimoRepositorio
{
  public void Adicionar(Emprestimo emprestimo);
  public Emprestimo BuscarPorId(Guid id);
}