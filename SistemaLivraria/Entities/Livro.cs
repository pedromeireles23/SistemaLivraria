 class Livro
{
    public  string Id {get; private set;} 
    public  string Titulo {get; private set;} 
    public  string Autor {get; private set;} 
    public bool EstaDisponivel {get; private set;} 

    public Livro(string id, string titulo, string autor)
  {
    ArgumentNullException.ThrowIfNull(id);
    ArgumentNullException.ThrowIfNull(titulo);
    ArgumentNullException.ThrowIfNull(autor);
    Id = id;
    Titulo = titulo;
    Autor = autor;
    EstaDisponivel = true;

  }

  public void Emprestar()
  {
    if (EstaDisponivel)
    {
      EstaDisponivel = false;
    }
    else
    {
      throw new Exception ("Livro não está disponível");
    }
  }

  public void Devolver()
  {
     if (!EstaDisponivel)
    {
      EstaDisponivel = true;
    }
    else
    {
      throw new Exception ("Livro já foi devolvido");

    }
  }
   
}