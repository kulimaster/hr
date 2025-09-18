using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveTypeId { get; set; }
    public LeaveType? LeaveType { get; set; }
    
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; } = string.Empty;
    public string? ApprovedBy { get; set; }
    public DateTime? DateActioned { get; set; }
    public bool? Approved { get; set; }
    public string EmployeeId { get; set; } = string.Empty;
}