using MemberActivites.Infrastructure.Database;
using MemberActivities.Domain;
using MemberActivities.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivites.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public IMemberRepository MemberRepository { get; set; }    

        public UnitOfWork(DatabaseContext databaseContext, IMemberRepository memberRepository) {
            
            _databaseContext = databaseContext;

            MemberRepository = memberRepository;
        }
        public async Task<int> CompleteAsync()
        {
            return await _databaseContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _databaseContext.Dispose();
        }
    }
}
