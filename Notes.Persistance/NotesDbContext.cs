using Microsoft.EntityFrameworkCore;
using Notes.Application.interfaces;
using Notes.Domain;
using Notes.Persistencs.EntityTypeConfigurations;

namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
            public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfigutation());
            base.OnModelCreating(builder);
        }

    }
}
