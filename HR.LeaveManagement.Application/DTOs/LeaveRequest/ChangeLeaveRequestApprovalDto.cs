using HR.LeaveManagement.Application.DTOs.Commom;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using System;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }

    }
}
