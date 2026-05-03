
public class Biblioteca
{
  public List <Emprestimo> ListaEmprestimo {get; private set;}
  public List <Livro> ListaLivros {get;private set;}
  public List <Usuario> ListaUsuarios {get;private set;}

  public Biblioteca()
  {
    ListaEmprestimo = new List<Emprestimo>();
    ListaLivros = new List<Livro>();
    ListaUsuarios = new List<Usuario>();
  }

  public void AdicionarLivro(Livro livro)
  {
    ListaLivros.Add(livro);
  }
  public void AdicionarUsuario(Usuario usuario)
  {
    ListaUsuarios.Add(usuario);
  }
  public void EmprestarLivro(Guid idLivro, Guid idUsuario)
  {
   var existeUsuario = ListaUsuarios.FirstOrDefault(u => u.Id == idUsuario);
   var existeLivro = ListaLivros.FirstOrDefault(l => l.Id == idLivro);
   if(existeLivro != null && existeUsuario != null)
    {
      Emprestimo novoEmprestimo = new Emprestimo(existeLivro, existeUsuario);
      ListaEmprestimo.Add(novoEmprestimo);
    }
    else
    {
      throw new ArgumentNullException("O objeto não pode ser nulo.");

    }
    
  }

}