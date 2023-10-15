
using HR.LeaveManagement.Application.DTOs.Commom;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
      

        public string Name { get; set; }

        public int DefaultDays { get; set; }

    }
}
