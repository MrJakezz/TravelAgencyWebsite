using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
	public class CustomIdentityViewModel : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError
			{
				Code = "PasswordTooShort",
				Description = $"Şifre minimum {length} karakter olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresDigit",
				Description = "Şifre rakam içermelidir."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresUpper",
				Description = "Şifre en az bir büyük harf içermelidir."
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresLower",
				Description = "Şifre en az bir küçük harf içermelidir."
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Şifre harf ve rakamlardan oluşmalıdır."
			};
		}
	}
}
