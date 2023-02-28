using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Common
{
    public class Pagination
    {
        public int skip { get; set; } = 0;
        public int limit { get; set; } = 10;

    }
}
