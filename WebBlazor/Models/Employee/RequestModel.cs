namespace WebBlazor.Models.Employee
{
    public class RequestModel
    {
        public DateTime DayRequest { get; set; }
        public ShiftModel Change { get; set; }
        public EmployeeModel Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
