using BookshelfAPI.Models;

namespace BookshelfAPI.Validators
{
	public class AuthorValidator : IValidator<Author>
	{
		public AuthorValidator()
		{
		}

        public bool validate(Author data)
        {
            return data.id > 0 && data.name != ""; 
        }
    }
}

