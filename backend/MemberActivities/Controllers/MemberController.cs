using MemberActivities.Domain.Common;
using MemberActivities.Domain.DTOs;
using MemberActivities.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace MemberActivities.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        public readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<MemberDTO>> GetStudentById(int id)
        {
            var member = await _memberService.GetMemberById(id);
            return Ok(member);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetAll([FromQuery] Pagination pagination)
        {
            var members = await _memberService.GetAllMembers(pagination);
            return Ok(members);
        }

        [HttpPost]
        public async Task<ActionResult<MemberDTO>> Post([FromBody] MemberDTO member)
        {
            var createStudent = await _memberService.AddMember(member);
            return Ok(createStudent);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] MemberDTO member)
        {
            await _memberService.UpdateMember(member);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _memberService.DeleteMember(id);
            return Ok();
        }



    }
}
