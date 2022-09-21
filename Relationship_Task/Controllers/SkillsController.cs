using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Relationship_Task.Interfaces;
using Relationship_Task.Services;

namespace Relationship_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkill _skill;
        public SkillsController(ISkill skill)
        {
            _skill = skill;
        }

        [HttpGet]
        [Route("GetSkills")]
        public async Task<IActionResult> GetSkills()
        {
            try
            {
                var result = await _skill.GetAllSkills();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
