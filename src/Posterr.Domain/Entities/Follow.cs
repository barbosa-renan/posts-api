namespace Posterr.Domain.Entities
{
    public class Follow : BaseEntity
    {
        public int UserId { get; set; }
        public int UserFollowedId { get; set; }

        //EF Relations
        public virtual User User { get; set; }
        public virtual User UserFollowed { get; set; }
    }
}