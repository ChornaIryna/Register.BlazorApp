using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
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

    public Person Person { get; set; } = new Person();

    protected IQueryable<ActivityLog>? itemsQueryable;
    protected int queryableCount = 0;
    public PaginationState pagination = new() { ItemsPerPage = 10 };
    protected override async Task OnInitializedAsync()
    {
        Person = await PersonDataService.GetPersonByIdAsync(PersonId);

        itemsQueryable = (await ActivityLogDataService!.GetPersonActivityLogsAsync(PersonId)).AsQueryable();
        queryableCount = itemsQueryable.Count();
    }
    private void ChangeHolidayState() => Person.IsOnHoliday = !Person.IsOnHoliday;
}
