using MemberActivities.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Exceptions
{
    public class ConflictException : BaseException
    {
        public ConflictException() : base(HttpStatusCode.Conflict)
        {
        }

        public ConflictException(string message) : base(HttpStatusCode.Conflict, message)
        {
        }
    }
}
