namespace Application.Dto
{
    public class PlanMonthDto
    {
        public DateTime DateMonth { get; set; }
        public string DateMonthBy { get; set; }
        public ICollection<PlanDayDto> PlanDays { get; set; }
        public WardDto Ward { get; set; }
        public int WardId { get; set; }
        public bool ActivePlanMonth { get; set; }
    }
}
