using Relationship_Task.Models;

namespace Relationship_Task.Interfaces
{
    public interface IEmployee
    {
        Task<IEnumerable<Employeeswithskills>> GetAllEmployees();
    }
}
