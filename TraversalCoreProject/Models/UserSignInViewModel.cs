using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        public string Password { get; set; }
    }
}
