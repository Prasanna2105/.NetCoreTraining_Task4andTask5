using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relationship_Task.Models
{
    public class Skills
    {
        
        [Key]
        public int skillid { get; set; }
        public string skillname { get; set; }
        public ICollection<Skillmaps> Skillmaps { get; set; }
    }
    public class Skillswithemployees
    {
        [Key]
        public int skillid { get; set; }
        public string skillname { get; set; }
        [NotMapped]
        public List<string> Employees { get; set; }

    }

}
