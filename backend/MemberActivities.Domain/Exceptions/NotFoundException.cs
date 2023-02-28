using MemberActivities.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException() : base(HttpStatusCode.NotFound) { }

        public NotFoundException(string message) : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
