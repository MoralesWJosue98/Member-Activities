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
    public class AcitivtyRepository : Repository<Activity>, IActivityRepository
    {
        public AcitivtyRepository(DbSet<Activity> entities) : base(entities)
        {
        }
    }
}
