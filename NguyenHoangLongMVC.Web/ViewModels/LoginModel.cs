using System.ComponentModel.DataAnnotations;

namespace NguyenHoangLongMVC.Web.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
