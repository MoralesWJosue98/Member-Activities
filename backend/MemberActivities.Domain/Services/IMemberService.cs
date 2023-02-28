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
        Task<ActivityDTO> GetActivtyById(int id);
        Task<IEnumerable<ActivityDTO>> GetAllActivity(Pagination pagination);
        Task<ActivityDTO> AddActivty(ActivityDTO activityDTO);
        Task UpdateActivity(ActivityDTO activityDTO);
        Task DeleteActivity(int id);


    }
}
