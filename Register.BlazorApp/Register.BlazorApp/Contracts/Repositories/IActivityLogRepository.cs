using Register.Shared.Domain;

namespace Register.BlazorApp.Contracts.Repositories;
public interface IActivityLogRepository
{
    Task<List<ActivityLog>> GetPagedPersonActivityLogs(int personId, int pageSize, int currentPage);
    Task<List<ActivityLog>> GetPersonActivityLogs(int personId);
    Task<int> GetPersonActivityLogsCount(int personId);
}