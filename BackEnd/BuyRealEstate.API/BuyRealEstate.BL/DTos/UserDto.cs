using System.ComponentModel.DataAnnotations;
using BuyRealEstate.Domain.Models;
using System.Collections.Generic;

namespace BuyRealEstate.Core.DTos
{
    public class UsersDTO
    {
        public int ID { get; set; }

        public PermissionDTO? Permission { get; set; }

        // [Required(ErrorMessage = "מספר הרשאה הוא שדה חובה")]
        public int PermissionId { get; set; } = 3;

        [Required(ErrorMessage = "שם משתמש הוא שדה חובה")]
        [StringLength(50, ErrorMessage = "שם משתמש לא יכול להכיל יותר מ-50 תווים")]
        public string Username { get; set; }

        [Required(ErrorMessage = "סיסמה היא שדה חובה")]
        [MinLength(6, ErrorMessage = "סיסמה חייבת להכיל לפחות 6 תווים")]
        public string Password { get; set; }

        [Required(ErrorMessage = "שם פרטי הוא שדה חובה")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "שם משפחה הוא שדה חובה")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "אימייל הוא שדה חובה")]
        [EmailAddress(ErrorMessage = "כתובת האימייל לא תקינה")]
        public string Email { get; set; }

        [Required(ErrorMessage = "טלפון ראשי הוא שדה חובה")]
        [RegularExpression(@"^\d{9,10}$", ErrorMessage = "מספר טלפון חייב להכיל 9-10 ספרות")]
        public string FirstPhone { get; set; }

        [RegularExpression(@"^\d{9,10}$", ErrorMessage = "מספר טלפון משני חייב להכיל 9-10 ספרות")]
        public string? SecendPhon { get; set; }

        public string? VerificationCode { get; set; } // קוד האימות
        public bool? IsVerified { get; set; } // האם המשתמש אושר
        public DateTime? VerificationCodeExpiry { get; set; }

        public ICollection<Plot> Plots { get; set; }
        public ICollection<DocumentDTO> Documents { get; set; }
    }
}
