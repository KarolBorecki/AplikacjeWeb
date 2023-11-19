using System;
namespace BookshelfAPI.Validators
{
	public interface IValidator<T>
	{
		bool validate(T data);
	}
}

