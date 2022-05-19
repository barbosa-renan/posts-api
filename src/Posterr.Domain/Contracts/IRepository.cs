using Posterr.Domain.Contracts;
using System;

namespace Posterr.Domain.Contracts
{
    public interface IRepository<T> : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void GetById(Guid id);
    }
}