using Microsoft.EntityFrameworkCore;
using Relationship_Task.Interfaces;
using Relationship_Task.Models;

namespace Relationship_Task.Services
{
    public class EmployeeService: IEmployee
    {
        private readonly DBContext _dbContext;
        public EmployeeService(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<IEnumerable<Employeeswithskills>> GetAllEmployees()
        {
            var result = await _dbContext.Employees.Include(x => x.Skillmaps).ThenInclude(x => x.skills).Select(x => new Employeeswithskills
            {
                employee_id = x.employee_id,
                employee_name = x.employee_name,
                status = x.status,
                manager = x.manager,
                wfm_manager = x.wfm_manager,
                email = x.email,
                experience = x.experience,
                lockstatus = x.lockstatus,
                Skills = x.Skillmaps.Select(y => y.skills.skillname).ToList()
            }).ToListAsync();

            return result;
        }
    }
}
