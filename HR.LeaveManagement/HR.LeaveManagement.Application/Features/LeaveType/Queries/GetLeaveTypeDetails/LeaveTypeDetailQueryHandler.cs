using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public class LeaveTypeDetailQueryHandler : IRequestHandler<LeaveTypeDetailQuery, LeaveTypeDetailDto>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public async Task<LeaveTypeDetailDto> Handle(LeaveTypeDetailQuery request, CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);
        return _mapper.Map<LeaveTypeDetailDto>(leaveType);
    }
}