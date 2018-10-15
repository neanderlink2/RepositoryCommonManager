using System;
using System.Linq.Expressions;

namespace RepositoryManager.Common.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Salvar(T[] pessoas);
        T[] GetAll();
        T[] GetMany(Expression<Func<T, bool>> expressao);
        T GetSingle(Expression<Func<T, bool>> expressao);
    }
}
