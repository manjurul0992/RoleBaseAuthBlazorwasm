using AssessmentMash.Server.AuthenticationModel;
using AssessmentMash.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentMash.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<SellerPost> SellerPosts { get; set; } = null!;
        public DbSet<BuyerPost> BuyerPosts { get; set; } = null!;
        public DbSet<Register> Registers { get; set; } = default!;
        public DbSet<TokenInfo> TokenInfo { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; } = default!;
    }
}
