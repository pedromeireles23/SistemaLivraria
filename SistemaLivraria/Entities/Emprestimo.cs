public class Emprestimo
{
  public Livro Livro {get; private set;}
  public Usuario Usuario {get; private set;}
  public DateTime DataEmprestimo {get; private set;}

  public Emprestimo(Livro livro, Usuario usuario)
  {
    ArgumentNullException.ThrowIfNull(livro); 
    ArgumentNullException.ThrowIfNull(usuario); 
  
    Livro = livro;
    Usuario = usuario;
    DataEmprestimo = DateTime.Now;
    Livro.Emprestar();
    
  }
}