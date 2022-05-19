using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Posterr.Application.Posts
{
    public class CreatePostCommand : IRequest<Guid>
    {
        public string Text { get; set; }
        public Guid OwnerId { get; set; }
    }
}
