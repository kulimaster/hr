using FluentValidation;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreatedLeaveTypeCommandValidator : AbstractValidator<CreateLeaveTypeCommand>
{
    public CreatedLeaveTypeCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        RuleFor(x => x.DefaultDays)
            .GreaterThan(100).WithMessage("{PropertyName} must be greater than 100.")
            .LessThan(1).WithMessage("{PropertyName} must be less than 1.");
        
    }
    
    
}