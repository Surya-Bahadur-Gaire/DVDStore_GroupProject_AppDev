using System.ComponentModel.DataAnnotations;

namespace DVDStore_GroupProject_AppDev.Models
{
    public class AppUsers
    {
        [Key]
        public int UserNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User Type is required")]
        public string UserType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User Email is required")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password didn't Match")]
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Date is required")]
        public DateTime CreatedDate { get; set; }
    }
}
