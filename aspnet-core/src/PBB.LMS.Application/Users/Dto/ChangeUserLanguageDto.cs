using System.ComponentModel.DataAnnotations;

namespace PBB.LMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}