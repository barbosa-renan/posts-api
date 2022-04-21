namespace Posterr.Domain.Entities
{
    public abstract class BaseEntity<TType>
    {
        public TType Id { get; set; }
    }
}