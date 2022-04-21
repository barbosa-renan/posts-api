using System;
using System.Collections.Generic;

namespace Posterr.Domain.Entities
{
    public sealed class User : BaseEntity<Guid>
    {
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }

        //EF Relations
        public ICollection<User> Followers { get; set; }
        public ICollection<User> Following { get; set; }
    }
}