using Bogus;
using Posterr.Domain.Entities;
using Posterr.Domain.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Posterr.DomainTests.Posts
{
    public class PostTests
    {
        [Fact(DisplayName = "Create a new post")]
        [Trait("Category", "Post-Domain")]
        public void CreatePost_NewPost_MustCreatePostAsDraft()
        {
            // Arrange
            var post = Post.PostFactory.NewPostDraft(Guid.NewGuid(), new Bogus.DataSets.Lorem().Sentence(2));

            // Act & Assert
            Assert.True(post.Status.Equals(PostStatus.Draft));
        }

        [Fact(DisplayName = "Post text can have a maximum 777 characters")]
        [Trait("Category", "Post-Domain")]
        public void CreatePost_NewPostAsDraft_TextMustHaveLessThan777Characters()
        {
            // Arrange
            var lorem = new Bogus.DataSets.Lorem();
            var post = Post.PostFactory.NewPostDraft(Guid.NewGuid(), lorem.Letter(Post.MAX_TEXT_SIZE));

            // Act
            var validate = post.Validate();

            // Assert
            Assert.True(validate.IsValid);
            Assert.True(validate.Errors.Count == 0);
            Assert.False(validate.Errors.Exists(x => x.ErrorMessage.Equals(PostValidation.TextSizeErrorMessage)));
        }
    }
}