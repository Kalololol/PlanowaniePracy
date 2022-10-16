using Application.Dto;
using AutoMapper;
using Domain.Entities.Planner;
using Domain.Entities.Team;
using Domain.Entities.Team.WardPreferences;
using Domain.Work;

namespace Application.Mappings
{
    public class AutoMapperConfig 
    {
       public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Contract, ContractDto>();
                cfg.CreateMap<Employee, EmployeeDto>();
                cfg.CreateMap<Indisposition, IndispositionDto>();
                cfg.CreateMap<Manager, ManagerDto>();
                cfg.CreateMap<PlanDay, PlanDayDto>();
                cfg.CreateMap<PlanMonth, PlanMonthDto>();
                cfg.CreateMap<Request, RequestDto>();
                cfg.CreateMap<Ward, WardDto>();
                cfg.CreateMap<WorkAssumptions, WorkAssumptionsDto>();
            }).CreateMapper();
    }
}
