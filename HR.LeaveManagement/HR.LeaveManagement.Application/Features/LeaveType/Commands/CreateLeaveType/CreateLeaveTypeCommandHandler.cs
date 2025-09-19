using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await new CreatedLeaveTypeCommandValidator().ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            throw new (validationResult.Errors.First().ErrorMessage);
        }
        var leaveType = mapper.Map<Domain.LeaveType>(request);
        var createdLeaveType = await leaveTypeRepository.AddAsync(leaveType);
        return createdLeaveType.Id;
    }
}