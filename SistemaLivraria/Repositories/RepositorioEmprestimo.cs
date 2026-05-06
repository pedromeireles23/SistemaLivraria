class RepositorioEmprestimo : IEmprestimoRepositorio
{
  private List <Emprestimo> _emprestimos;

  public RepositorioEmprestimo()
  {
    _emprestimos = new List<Emprestimo>();
  }

  public void Adicionar(Emprestimo emprestimo)
  {
    _emprestimos.Add(emprestimo);
  }

  public Emprestimo BuscarPorId (Guid id)
  {
    var idEmprestimo = _emprestimos.FirstOrDefault(e => e.Id == id);
    return idEmprestimo;
  }

  
  
}