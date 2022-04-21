using System;
using System.Collections.Generic;
using System.Text;

namespace Posterr.Domain.Entities
{
    public sealed class Post : BaseEntity
    {
        public string Text { get; set; }
        public Guid OwnerId { get; set; }
        public PostStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }

        //EF Relations
        public User Owner { get; set; }

        public void BecomeDraft() => Status = PostStatus.Draft;

        public static class PostFactory
        {
           public static Post NewPostDraft(Guid ownerId, string text)
            {
                var post = new Post
                {
                    OwnerId = ownerId,
                    Text = text,
                    CreatedOn = new DateTime()
                };

                post.BecomeDraft();

                return post;
            }
        }

       
    }
}
