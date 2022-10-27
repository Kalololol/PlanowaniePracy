namespace WebMVC.Models.Employee
{ 
    public class IndispositionModel
    {
        public DateTime DayIndisposition { get; set; }
        public ShiftModel Change { get; set; }
        public EmployeeModelMVC Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
