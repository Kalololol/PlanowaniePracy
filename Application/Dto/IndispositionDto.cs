namespace Application.Dto
{
    public class IndispositionDto
    {
        public DateTime DayIndisposition { get; set; }
        public ShiftDto Change { get; set; }
        public EmployeeDto Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
