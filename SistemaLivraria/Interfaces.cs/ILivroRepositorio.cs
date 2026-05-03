interface ILivroRepositorio
{
   void Adicionar(Livro livro);
  Livro BuscarPorId(Guid id);
}