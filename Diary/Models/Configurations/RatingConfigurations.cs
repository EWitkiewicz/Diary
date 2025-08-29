using Diary.Models.Domains;
using System.Data.Entity.ModelConfiguration;


namespace Diary.Models.Configurations
{
    public class RatingConfigurations: EntityTypeConfiguration<Rating>
    {
        public RatingConfigurations()
        {
            ToTable("dbo.Ratings");

            HasKey(x => x.Id);
        }
    }
}
