﻿using HR.LeaveManagement.Application.DTOs.Commom;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using System;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto 
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }

    }
}
