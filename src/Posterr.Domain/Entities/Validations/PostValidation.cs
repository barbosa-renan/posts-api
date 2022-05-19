using FluentValidation;

namespace Posterr.Domain.Entities.Validations
{
    public class PostValidation : AbstractValidator<Post>
    {
        public static string TextNotEmpty => "Post text must not be empty.";
        public static string TextSizeErrorMessage => $"Post text must have less than or equal to { Post.MAX_TEXT_SIZE } characters.";
        public PostValidation()
        {
            RuleFor(x => x.Text)
                .NotEmpty()
                .WithMessage(TextNotEmpty);

            RuleFor(x => x.Text.Length)
                .LessThanOrEqualTo(Post.MAX_TEXT_SIZE)
                .WithMessage(TextSizeErrorMessage);
        }
    }
}
