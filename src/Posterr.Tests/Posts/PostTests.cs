using Posterr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Posterr.DomainTests.Posts
{
    public class PostTests
    {
        [Fact(DisplayName = "Create a new post")]
        [Trait("Category", "Post Commands")]
        public void CreatePost_NewPost_MustCreatePostAsDraft()
        {
            // Arrange
            var post = Post.PostFactory.NewPostDraft(Guid.NewGuid(), "Some post text");

            // Act & Assert
            Assert.True(post.Status.Equals(PostStatus.Draft));
        }
    }
}