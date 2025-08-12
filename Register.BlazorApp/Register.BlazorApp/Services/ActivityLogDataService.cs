using Register.BlazorApp.Contracts.Repositories;
using Register.BlazorApp.Contracts.Services;
using Register.Shared.Domain;

namespace Register.BlazorApp.Services;

public class ActivityLogDataService(IActivityLogRepository logRepository) : IActivityLogDataService
{
    public async Task<List<ActivityLog>> GetPagedPersonActivityLogsAsync(int personId, int pageSize, int currentPage) =>
        await logRepository.GetPagedPersonActivityLogs(personId, pageSize, currentPage);

    public async Task<List<ActivityLog>> GetPersonActivityLogsAsync(int personId) =>
        await logRepository.GetPersonActivityLogs(personId);

    public async Task<int> GetPersonActivityLogsCountAsync(int personId) =>
        await logRepository.GetPersonActivityLogsCount(personId);
}
