using Microsoft.EntityFrameworkCore;
using Relationship_Task.Interfaces;
using Relationship_Task.Models;

namespace Relationship_Task.Services
{
    public class SkillService: ISkill
    {

        private readonly DBContext _dbContext;
        public SkillService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<IEnumerable<Skillswithemployees>> GetAllSkills()
        {
            var result = await _dbContext.Skills.Include(x => x.Skillmaps).ThenInclude(x => x.skills).Select(x => new Skillswithemployees
            {
                skillid = x.skillid,
                skillname = x.skillname,
                Employees = x.Skillmaps.Select(y => y.employees.employee_name).ToList()
            }).ToListAsync();
            return result;
        }
    }
}
