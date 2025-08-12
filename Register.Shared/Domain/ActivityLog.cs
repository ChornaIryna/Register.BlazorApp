namespace Register.Shared.Domain;
public class ActivityLog
{
    public int ActivityLogId { get; set; }
    public int PersonId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string PerformedActivityDescription { get; set; } = string.Empty;
}
