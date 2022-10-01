using OpenBootcamp.Enums;
using System.ComponentModel.DataAnnotations;

namespace OpenBootcamp.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(250)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        public string LargeDescription { get; set; } = string.Empty;

        public string PublicObjetive { get; set; } = string.Empty;

        public string Objetives { get; set; } = string.Empty;

        public string Requirements { get; set; } = string.Empty;

        public LevelEnum Level { get; set; } = LevelEnum.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();


    }
}
