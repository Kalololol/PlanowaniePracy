namespace WebBlazor.Models.Employee
{
    public class IndispositionModel
    {
        public DateTime DayIndisposition { get; set; }
        public ShiftModel Change { get; set; }
        public EmployeeModel Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
