using System.Data.Entity.ModelConfiguration;

namespace AnotherUnwantedBlog.DAL.Models.Mappings
{
    public class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            HasKey(author => author.Id);
            Property(author => author.Name).HasMaxLength(50).IsRequired();
            
        }
    }
}
