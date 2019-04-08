using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Vote { get; set; }

        [NotMapped]
        public bool Checkbox { get; set; }
    }
}
