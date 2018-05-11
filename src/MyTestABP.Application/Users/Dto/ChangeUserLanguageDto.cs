using System.ComponentModel.DataAnnotations;

namespace MyTestABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}