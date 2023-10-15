﻿using HR.LeaveManagement.Application.DTOs.Commom;

using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveRequestListDto : BaseDto
    {

        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
    }
}