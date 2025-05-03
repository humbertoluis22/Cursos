using Core.Entity;

namespace Core.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        IList<T> ObterTodos();
        T obterPorId(int id);

        void Cadastrar(T entidade);
        void Alterar(T entidade);
        void deletar(int id);
    }
}
