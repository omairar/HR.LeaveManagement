﻿using HR.LeaveManagement.Domain.Commom;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Domain
{
    public class LeaveTypeDto : BaseDto
    {
      

        public string Name { get; set; }

        public int DefaultDays { get; set; }

    }
}
