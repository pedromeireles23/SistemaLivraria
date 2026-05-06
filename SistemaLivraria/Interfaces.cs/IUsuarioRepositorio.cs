public interface IUsuarioRepositorio
{
  public void Adicionar(Usuario usuario);
  public Usuario BuscarPorId(Guid id);
}