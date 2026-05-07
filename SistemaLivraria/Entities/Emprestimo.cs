
public class Emprestimo
{
  public Livro Livro {get; private set;}
  public Usuario Usuario {get; private set;}
  public DateTime DataEmprestimo {get; private set;}
  public DateTime? DataDevolucao {get; private set;}

  public Guid Id {get;private set;}

  public Emprestimo(Livro livro, Usuario usuario)
  {
    ArgumentNullException.ThrowIfNull(livro); 
    ArgumentNullException.ThrowIfNull(usuario); 
  
    Livro = livro;
    Usuario = usuario;
    DataEmprestimo = DateTime.Now;
    Livro.Emprestar();
    Id = new Guid();
    
  }

  public void DevolverLivro()
  {
    
    if (DataDevolucao == null)
    {
      DataDevolucao = DateTime.Now;
      Livro.Devolver();

    }
    else
    {
      throw new Exception ("Livro já foi devolvido");
    }
    
  }
}