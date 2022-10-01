using System.ComponentModel.DataAnnotations;

namespace OpenBootcamp.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        public ICollection<Curso> Curso { get; set; } = new List<Curso>();
    }
}
