using System.ComponentModel.DataAnnotations;

namespace CoreWeb0522.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}