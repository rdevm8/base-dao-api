using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using base_dao_api.Models;

namespace base_dao_api.Data.ContextConfigurations
{
    public class FaqContextConfiguration : IEntityTypeConfiguration<Faq>
    {
        
        public FaqContextConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            string defAnswer = "At vero eos et accusamus et iusto";

            builder.HasIndex(x => x.Order).IsUnique();

            builder
                .HasData(
                new Faq
                {
                    Question = "What is Wick's Crew?",
                    Answer = defAnswer,
                    Order = 1
                },
                new Faq
                {
                    Question = "What are Pooling Considerations?",
                    Answer = defAnswer,
                    Order = 2
                },
                new Faq
                {
                    Question = "What are the Pooling Rules?",
                    Answer = defAnswer,
                    Order = 3
                },
                new Faq
                {
                    Question = "What are the Available Pools?",
                    Answer = defAnswer,
                    Order = 4
                },
                new Faq
                {
                    Question = "How are the Funds Distributed?",
                    Answer = defAnswer,
                    Order = 5
                });
        }
    }
}