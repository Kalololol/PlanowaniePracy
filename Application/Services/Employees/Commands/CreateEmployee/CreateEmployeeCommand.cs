﻿using MediatR;

namespace Application.Services.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }

    }
}

