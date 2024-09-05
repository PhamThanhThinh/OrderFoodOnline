using System.ComponentModel.DataAnnotations;

namespace OrderFoodOnline.Models
{
  public class LoginViewModel
  {
    //Required bắt buộc trường không để trống
    //@tên miền đúng định dạng EmailAddress
    [Required, EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }
  }
}
