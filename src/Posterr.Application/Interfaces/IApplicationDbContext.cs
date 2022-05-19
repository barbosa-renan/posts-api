using Microsoft.EntityFrameworkCore;
using Posterr.Domain.Entities;
using System.Threading.Tasks;

namespace Posterr.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Post> Posts { get; set; }
        Task<int> SaveChanges();
    }
}
