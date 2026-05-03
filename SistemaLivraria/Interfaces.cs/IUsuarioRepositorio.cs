interface IUsuarioRepositorio
{
  void Adicionar(Usuario usuario);
  Usuario BuscarPorId(Guid id);
}