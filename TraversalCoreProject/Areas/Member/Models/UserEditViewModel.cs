namespace TraversalCoreProject.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string UserEditName { get; set; }
        public string UserEditSurname { get; set; }
        public string UserEditPassword { get; set; }
        public string UserEditConfirmPassword { get; set; }
        public string UserEditPhoneNumber { get; set; }
        public string UserEditMail{ get; set; }
        public string UserEditUrlImage { get; set; }
        public IFormFile UserEditImage { get; set; }
    }
}
