using Bogus;
namespace BookshelfAPI.Models
{
	public class DataSeeder
	{
        private int authorsCount;
        private int booksCount;
        private int seed;

        public DataSeeder(int authorsCount, int booksCount, int seed)
        {
            this.authorsCount = authorsCount;
            this.booksCount = booksCount;
            this.seed = seed;
        }

        public List<Book> GenerateBooksData()
        {
            int nextId = 1;
            var generator = new Random();
            var productFaker = new Faker<Book>("pl")
                .UseSeed(seed)
                .RuleFor(x => x.id, x => nextId++)
                .RuleFor(x => x.authorId, x => generator.Next(1, authorsCount))
                .RuleFor(x => x.name, x => x.Commerce.ProductName())
                .RuleFor(x => x.publishDate, x => x.Date.Past());

            return productFaker.Generate(booksCount).ToList();

        }

        public List<Author> GenerateAuthorData()
        {
            int nextId = 1;
            var generator = new Random();
            var productFaker = new Faker<Author>("pl")
                .UseSeed(seed)
                .RuleFor(x => x.name, x => x.Name.FullName())
                .RuleFor(x => x.id, x => nextId++);

            return productFaker.Generate(authorsCount).ToList();

        }
    }
}

