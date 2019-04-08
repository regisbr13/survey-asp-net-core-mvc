using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey.Models
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Vote { get; set; }

        [NotMapped]
        [Required]
        public bool Checkbox { get; set; }

        public ProgrammingLanguage()
        {
        }

        public ProgrammingLanguage(string name, int vote)
        {
            Name = name;
            Vote = vote;
        }
    }
}
