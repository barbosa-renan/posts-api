using Posterr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Posterr.Domain.Contracts
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByUserId(Guid userId);
    }
}
