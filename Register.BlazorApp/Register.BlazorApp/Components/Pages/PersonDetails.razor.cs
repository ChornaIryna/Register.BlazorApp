using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Register.BlazorApp.Contracts.Services;
using Register.Shared.Domain;

namespace Register.BlazorApp.Components.Pages;

public partial class PersonDetails
{
    [Parameter]
    public int PersonId { get; set; }

    [Inject]
    public IPersonDataService? PersonDataService { get; set; }

    [Inject]
    public IActivityLogDataService? ActivityLogDataService { get; set; }

    public List<ActivityLog> ActivityLogs { get; set; } = [];

    public Person Person { get; set; } = new Person();

    private float itemHeight = 50;

    protected override async Task OnInitializedAsync()
    {
        Person = await PersonDataService.GetPersonByIdAsync(PersonId);

        ActivityLogs = await ActivityLogDataService!.GetPersonActivityLogsAsync(PersonId);
    }

    public async ValueTask<ItemsProviderResult<ActivityLog>> LoadTimeRegistrations(ItemsProviderRequest request)
    {
        int totalNumberOfTimeRegistrations = await ActivityLogDataService!.GetPersonActivityLogsCountAsync(PersonId);

        var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
        var listItems = await ActivityLogDataService.GetPagedPersonActivityLogsAsync(PersonId, numberOfTimeRegistrations, request.StartIndex);

        return new ItemsProviderResult<ActivityLog>(listItems, totalNumberOfTimeRegistrations);
    }

    private void ChangeHolidayState() => Person.IsOnHoliday = !Person.IsOnHoliday;
}
