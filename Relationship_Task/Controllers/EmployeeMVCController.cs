using Microsoft.AspNetCore.Mvc;
using Relationship_Task.Interfaces;
using Relationship_Task.Services;

namespace Relationship_Task.Controllers
{
    public class EmployeeMVCController : Controller
    {

        private readonly IEmployee _employee;

        public EmployeeMVCController(IEmployee employee)
        {
            _employee = employee;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _employee.GetAllEmployees();
            return View(result);
        }

    }
}
