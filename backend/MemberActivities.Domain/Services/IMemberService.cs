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
        Task<MemberDTO> GetActivtyById(int id);
        Task<IEnumerable<MemberDTO>> GetAll(Pagination pagination);
        Task<MemberDTO> AddMember(MemberDTO memberDTO);


    }
}
