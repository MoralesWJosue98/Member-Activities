using MemberActivities.Domain.Common;
using MemberActivities.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Services
{
    public interface IMemberService
    {
        Task<MemberDTO> GetMemberById(int id);
        Task<IEnumerable<MemberDTO>> GetAllMembers(Pagination pagination);
        Task<MemberDTO> AddMember(MemberDTO memberDTO);
        Task UpdateMember(MemberDTO memberDTO);
        Task DeleteMember(int id);


    }
}
