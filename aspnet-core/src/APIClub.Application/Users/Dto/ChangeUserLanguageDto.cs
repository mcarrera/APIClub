using System.ComponentModel.DataAnnotations;

namespace APIClub.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}