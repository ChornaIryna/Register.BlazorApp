using Register.Shared.Domain;

namespace Register.BlazorApp.Contracts.Services;
public interface IActivityLogDataService
{
    Task<List<ActivityLog>> GetPagedPersonActivityLogsAsync(int personId, int pageSize, int currentPage);
    Task<List<ActivityLog>> GetPersonActivityLogsAsync(int personId);
    Task<int> GetPersonActivityLogsCountAsync(int personId);
}