using System.Threading.Tasks;

namespace Posterr.Domain.Contracts
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
