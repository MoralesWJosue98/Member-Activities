using AutoMapper;
using MemberActivities.Domain;
using MemberActivities.Domain.Common;
using MemberActivities.Domain.DTOs;
using MemberActivities.Domain.Entities;
using MemberActivities.Domain.Exceptions;
using MemberActivities.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MemberActivities.Application.Service
{
    public class MemberService : IMemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;

        public MemberService(IUnitOfWork unitOfWork, IMapper autoMapper)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = autoMapper;
        }

        public async Task<MemberDTO> AddMember(MemberDTO memberDTO)
        {
            var member = _autoMapper.Map<Member>(memberDTO);    
            await _unitOfWork.MemberRepository.AddAsync(member);
            await _unitOfWork.CompleteAsync();

            return _autoMapper.Map<MemberDTO>(memberDTO); 
        }

        public async Task DeleteMember(int id)
        {
            var exists = await _unitOfWork.MemberRepository.ExistAsync(x => x.Id == id);
            if (!exists)
                throw new NotFoundException("The member doesn't exist.");

            var member = await _unitOfWork.MemberRepository.GetByIdAsync(id);
            await _unitOfWork.MemberRepository.DeleteAsync(member);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<MemberDTO>> GetAllMembers(Pagination pagination)
        {
            var members = await _unitOfWork.MemberRepository.GetAllAsync(pagination.skip, pagination.limit);
            var memberDTO = _autoMapper.Map<IEnumerable<MemberDTO>>(members);

            return memberDTO;
        }

        public async Task<MemberDTO> GetMemberById(int id)
        {
            var studentExist = await _unitOfWork.MemberRepository.ExistAsync(x => x.Id == id);
            if (!studentExist)
                throw new NotFoundException("The member Doesn't Exist");

            var member = await _unitOfWork.MemberRepository.GetByIdAsync(id).ConfigureAwait(false);
            var memberDTO = _autoMapper.Map<MemberDTO>(member);

            return memberDTO;
        }

        public async Task UpdateMember(MemberDTO memberDTO)
        {
            var exist = await _unitOfWork.MemberRepository.ExistAsync(x => x.Id == memberDTO.Id);

            if (!exist)
                throw new ConflictException("The permission type doesn't exist.");

            var member = _autoMapper.Map<Member>(memberDTO);
            await _unitOfWork.MemberRepository.UpdateAsync(member);
            await _unitOfWork.CompleteAsync();
        }
    }
}
