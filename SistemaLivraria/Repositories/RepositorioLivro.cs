public class RepositorioLivro : ILivroRepositorio
{
  private List <Livro> _livros;

  public RepositorioLivro()
  {
    _livros = new List<Livro>();

  }

  public void Adicionar(Livro livro)
  {
    _livros.Add(livro);
  }

  public Livro BuscarPorId(Guid id)
  {
    var idLivro = _livros.FirstOrDefault(l => l.Id==id);
    return idLivro;
  }

}