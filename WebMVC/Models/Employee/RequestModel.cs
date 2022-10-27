namespace WebMVC.Models.Employee
{
    public class RequestModel
    {
        public DateTime DayRequest { get; set; }
        public ShiftModel Change { get; set; }
        public EmployeeModelMVC Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
