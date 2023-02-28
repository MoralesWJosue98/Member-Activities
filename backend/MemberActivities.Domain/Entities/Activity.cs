using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Entities
{
    public class Activity : BaseEntity
    {
        public string NameActivity { get; set; }
        public string Description { get; set; }
    }
}
