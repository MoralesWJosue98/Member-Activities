using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain.Common
{
    public enum HttpStatusCode
    {
        OK = 200,
        Created = 201,
        Accepted = 202,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        Conflict = 409,
        TooEarly = 425,
        InternalServerError = 500,
        BadGateway = 501,
        ServiceUnavailable = 503,
        HTTPVersionNotSupported = 505
    }
}
