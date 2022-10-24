namespace Application.Services.Employees.Queries
{
    public class EmployeeDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool ActiveAccount { get; set; }
        public int ContractId { get; set; }
        public int WardId { get; set; }
    }
}
