using Microsoft.EntityFrameworkCore;
using Register.BlazorApp.Contracts.Repositories;
using Register.BlazorApp.Data;
using Register.Shared.Domain;

namespace Register.BlazorApp.Repositories;

public class ActivityLogRepository(ApplicationDbContext context) : IActivityLogRepository, IDisposable
{
    public async Task<List<ActivityLog>> GetPersonActivityLogs(int personId) =>
        await context.ActivityLogs
                     .Where(log => log.PersonId == personId)
                     .OrderBy(log => log.StartTime)
                     .ToListAsync();

    public async Task<List<ActivityLog>> GetPagedPersonActivityLogs(int personId, int pageSize, int currentPage) =>
        await context.ActivityLogs
                     .Where(log => log.PersonId == personId)
                     .OrderBy(log => log.StartTime)
                     .Skip(currentPage)
                     .Take(pageSize)
                     .ToListAsync();

    public async Task<int> GetPersonActivityLogsCount(int personId) =>
        await context.ActivityLogs
                     .Where(log => log.PersonId == personId)
                     .CountAsync();
    public void Dispose() => context.Dispose();
}
