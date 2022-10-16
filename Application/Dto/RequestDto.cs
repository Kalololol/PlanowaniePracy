namespace Application.Dto
{
    public class RequestDto
    {
        public DateTime DayRequest { get; set; }
        public ShiftDto Change { get; set; }
        public EmployeeDto Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
