using MemberActivities.Domain.Entities;
using MemberActivities.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivites.Infrastructure.Repositories
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(DbSet<Member> entities) : base(entities)
        {
        }
    }
}
