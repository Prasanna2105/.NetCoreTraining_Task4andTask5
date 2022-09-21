namespace Relationship_Task.Models
{
    public class Skillmaps
    {
        public int employee_id { get; set; }
        public int skillid { get; set; }
        public Employees employees { get; set; }
        public Skills skills { get; set; }
    }
}

