using ChatModels;
using Microsoft.EntityFrameworkCore;

namespace ChatBuddySignalR.DBRepository
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
        public DbSet<Chat> Chats { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Chat>().
        //         HasOptional(e => e.Tags).
        //         WithMany().
        //         HasForeignKey(m => m.Tags_Id);
        //}
    }
}