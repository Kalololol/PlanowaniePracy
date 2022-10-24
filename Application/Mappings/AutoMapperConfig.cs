using Application.Dto;
using Application.Services.Employees.Commands.CreateEmployee;
using Application.Services.Employees.Queries;
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
                cfg.CreateMap<Contract, Contract>();
                cfg.CreateMap<EmployeeModel, Employee>().ReverseMap();  // reverseMap - mapowanie w odwrotną stronę
                cfg.CreateMap<Employee, CreateEmployeeCommand>().ReverseMap(); // +

                cfg.CreateMap<IndispositionDto, Indisposition>();
                cfg.CreateMap<ManagerDto, Manager>();
                cfg.CreateMap<PlanDayDto, PlanDay>();
                cfg.CreateMap<PlanMonthDto, PlanMonth>();
                cfg.CreateMap<RequestDto, Request>();
                cfg.CreateMap<WardDto, Ward>();
                cfg.CreateMap<WorkAssumptionsDto, WorkAssumptions>();
            }).CreateMapper();
    }
}
