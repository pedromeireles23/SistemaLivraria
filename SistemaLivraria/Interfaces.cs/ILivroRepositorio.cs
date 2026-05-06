public interface ILivroRepositorio
{
  public void Adicionar(Livro livro);
  public Livro BuscarPorId(Guid id);
}