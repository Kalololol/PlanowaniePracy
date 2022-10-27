namespace WebMVC.Models.Employee
{
    public class ContractModel
    {
        public int DeclaredHours { get; set; }
        public ContractTypeModel ContractType { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModelMVC Employee { get; set; }
    }
}
