using MemberActivities.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IMemberRepository MemberRepository { get; set; }
        Task<int> CompleteAsync();

    }
}
