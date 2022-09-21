using Relationship_Task.Models;

namespace Relationship_Task.Interfaces
{
    public interface ISkill
    {
        Task<IEnumerable<Skillswithemployees>> GetAllSkills();
    }
}
