namespace WebMVC.Models.Employee
{
    public class WardModel
    {
        public string WardName { get; set; }
        public ICollection<EmployeeModelMVC> Employees { get; set; }
    }
}
