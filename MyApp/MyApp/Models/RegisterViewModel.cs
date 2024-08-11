using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class RegisterViewModel
    {

       /* [Required(ErrorMessage = "使用者名稱不可空白!!")]
        public string Username { get; set; }


        [Required(ErrorMessage = "請輸入密碼")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "密碼長度應在6到20個字符之間")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "密碼和確認密碼不匹配")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "請輸入郵箱地址")]
        [EmailAddress(ErrorMessage = "請輸入有效的郵箱地址")]
        public string Email { get; set; }*/


        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? Email { get; set; }

    }


}