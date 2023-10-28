using BookshelfAPI.Models;

namespace BookshelfAPI.Validators
{
	public class BookValidator : IValidator<Book>
	{
		public BookValidator()
		{
		}

        public bool validate(Book data)
        {
            return data.id > 0 && data.name != "" && data.authorId > 0;
        }
    }
}

