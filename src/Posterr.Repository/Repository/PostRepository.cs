using Posterr.Domain.Contracts;
using Posterr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Posterr.Repository.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly PosterrContext _context;

        public PostRepository(PosterrContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Add(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public void GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetPostsByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        } 
    }
}
