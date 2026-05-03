interface IEmprestimoRepositorio
{
  void Adicionar(Emprestimo emprestimo);
  Emprestimo BuscarPorId(Guid id);
}