using MediatR;
using Posterr.Application.Interfaces;
using Posterr.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Posterr.Application.Posts
{
    public class PostHandler : IRequestHandler<CreatePostCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = Post.PostFactory.NewPostDraft(request.OwnerId, request.Text);

            _context.Posts.Add(post);

            await _context.SaveChanges();

            return post.Id;
        }
    }
}