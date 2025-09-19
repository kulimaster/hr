using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        //validate Data - Fluent Validation
        var leaveType = mapper.Map<Domain.LeaveType>(request);
        var createdLeaveType = await leaveTypeRepository.AddAsync(leaveType);
        return createdLeaveType.Id;
    }
}