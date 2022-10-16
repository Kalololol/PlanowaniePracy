namespace WebBlazor.Models.Employee

{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Password { get; set; }
        public bool ActiveAccount { get; set; }
        public ContractModel Contract { get; set; }
        public WardModel Ward { get; set; }
        public int WardId { get; set; }
        public ICollection<IndispositionModel> Indispositions { get; set; }
    }
}
