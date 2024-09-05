using System.ComponentModel.DataAnnotations;

namespace OrderFoodOnline.Models
{
  public class RegisterViewModel
  {
    //Required bắt buộc trường không để trống
    //@tên miền đúng định dạng EmailAddress
    // ? cho null
    [Required]
    public string? Name { get; set; }

    [Required]
    public string? Address { get; set; }
    
    [Required, EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }
  }
}
