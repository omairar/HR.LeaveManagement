using AutoMapper;
using HR.LeaveManagement.Application.DTOs.Commom;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using HR.LeaveManagement.Domain;


namespace HR.LeaveManagement.Application.Profiles
{
    //1. ad  mapping profile class
    //2. add AutoMapper.Extensions.Microsoft.DependencyInjection
    //3. automapper will allow conversion between dto and domain
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
