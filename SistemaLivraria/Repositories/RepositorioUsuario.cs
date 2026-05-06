public class RepositorioUsuario : IUsuarioRepositorio
{
  private List<Usuario> _usuarios;

  public RepositorioUsuario()
  {
    _usuarios = new List<Usuario>();
  }

    public void Adicionar(Usuario usuario)
  {
    _usuarios.Add(usuario);
  }

   public Usuario BuscarPorId(Guid id)
  {
    var idUsuario = _usuarios.FirstOrDefault(u => u.Id == id);
    return idUsuario;
  
  }


}