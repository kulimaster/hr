using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public record LeaveTypeDetailQuery(int Id) : IRequest<LeaveTypeDetailDto>
{
    
}