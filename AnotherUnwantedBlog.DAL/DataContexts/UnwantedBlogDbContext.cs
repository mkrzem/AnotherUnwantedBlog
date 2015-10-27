using AnotherUnwantedBlog.DAL.Models;
using AnotherUnwantedBlog.DAL.Models.Mappings;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AnotherUnwantedBlog.DAL.DataContexts
{
    public class UnwantedBlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public UnwantedBlogDbContext()
            : base("AnotherUnwantedBlog")
        {
        }

        public static UnwantedBlogDbContext Create()
        {
            return new UnwantedBlogDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new AuthorConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
