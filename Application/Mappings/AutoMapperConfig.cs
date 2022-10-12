using Application.Dto;
using AutoMapper;
using Domain.Entities.Team;

namespace Application.Mappings
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
                cfg.CreateMap<Contract, ContractDto>();
                cfg.CreateMap<Ward, WardDto>();
            }).CreateMapper();
    }
}
