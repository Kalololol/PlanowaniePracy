namespace Application.Dto
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool ActiveAccount { get; set; }
        public ContractDto Contract { get; set; }
        public int ContractId { get; set; }
        public WardDto Ward { get; set; }
        public int WardId { get; set; }

    }
}
