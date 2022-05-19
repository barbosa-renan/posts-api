using MediatR;
using Microsoft.EntityFrameworkCore;
using Posterr.Domain.Contracts;
using Posterr.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Posterr.Repository
{
    public class PosterrContext : DbContext, IUnitOfWork
    {
        private readonly IMediator _mediatorHandler;

        public PosterrContext(DbContextOptions<PosterrContext> options, IMediator mediatorHandler)
            : base(options)
        {
            _mediatorHandler = mediatorHandler;
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Follow> Follows { get; set; }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedOn") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("CreatedOn").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("CreatedOn").IsModified = false;
            }

            return await base.SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PosterrContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) 
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}