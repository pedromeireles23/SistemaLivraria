public class BibliotecaService
{
  private readonly IEmprestimoRepositorio _emprestimoRepositorio;
  private readonly ILivroRepositorio _livroRepositorio;
  private readonly IUsuarioRepositorio _usuarioRepositorio;

  public BibliotecaService(IEmprestimoRepositorio emprestimoRepositorio,ILivroRepositorio livroRepositorio, IUsuarioRepositorio usuarioRepositorio )
  {
    _emprestimoRepositorio = emprestimoRepositorio;
    _livroRepositorio = livroRepositorio;
    _usuarioRepositorio = usuarioRepositorio;
  }

  public void AdicionarLivro(Livro livro)
  {
    _livroRepositorio.Adicionar(livro);
  }
  public void AdicionarUsuario(Usuario usuario)
  {
    _usuarioRepositorio.Adicionar(usuario);
  }
  
  public void EmprestarLivro(Guid idLivro, Guid idUsuario)
  {
   var existeUsuario = _usuarioRepositorio.BuscarPorId(idUsuario);
   var existeLivro = _livroRepositorio.BuscarPorId(idLivro);
   if(existeLivro != null && existeUsuario != null)
    {
      Emprestimo novoEmprestimo = new Emprestimo(existeLivro, existeUsuario);
      _emprestimoRepositorio.Adicionar(novoEmprestimo);
    }
    else
    {
      throw new ArgumentNullException("Livro ou Usuário não podem ser nulos");

    }
    
  }
  public void FinalizarEmprestimo(Guid idEmprestimo)
  {
   var existeEmprestimo = _emprestimoRepositorio.BuscarPorId(idEmprestimo);
   if(existeEmprestimo != null)
    {
      existeEmprestimo.DevolverLivro();

    }
    else
    {
      throw new Exception ("Emprestimo não pode ser nulo");
    }
  }
}