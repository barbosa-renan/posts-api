using System;
using System.Collections.Generic;

namespace Posterr.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }

        //EF Relations
        public ICollection<Post> Posts { get; set; }
        public ICollection<Follow> Follows { get; set; }
    }
}