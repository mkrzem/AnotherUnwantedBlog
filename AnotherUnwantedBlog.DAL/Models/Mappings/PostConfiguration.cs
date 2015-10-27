using System.Data.Entity.ModelConfiguration;

namespace AnotherUnwantedBlog.DAL.Models.Mappings
{
    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasKey(post => post.Id);
            Property(post => post.Title).HasMaxLength(150).IsRequired();
            Property(post => post.Url).HasMaxLength(255);

            HasRequired(post => post.Author)
                .WithMany(author => author.Posts)
                .Map(post => post.MapKey("AuthorId"));
        }
    }
}
