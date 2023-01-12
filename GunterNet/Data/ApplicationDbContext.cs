using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GunterNet.Configs;
using GunterNet.Models.Users;
// ApplicationDbContext enable-migrations -contexttypename ApplicationDbContext
// Enable-Migrations -ProjectName GunterNet -ContextTypeName GunterNet.Data.ApplicationDbContext
// EntityFrameworkCore\Add-Migration Initial
namespace GunterNet.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FriendConfiguration());
            builder.ApplyConfiguration(new MessageConfuiguration());
        }
    }
}
