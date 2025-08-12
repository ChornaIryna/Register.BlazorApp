using Microsoft.AspNetCore.Components;
using Register.BlazorApp.Contracts.Services;
using Register.Shared.Domain;

namespace Register.BlazorApp.Components.Pages;
public partial class RegisterOverview
{
    private string Title = "Register overview";
    private string Description = "List of all registered persons";
    private Person? _selectedPerson;

    [Inject]
    public IPersonDataService? PersonDataService { get; set; }

    public List<Person> Persons { get; set; } = default!;

    protected override async Task OnInitializedAsync() =>
        Persons = [.. await PersonDataService.GetAllPersonsAsync()];

    public void ShowQuickViewPopup(Person person) =>
        _selectedPerson = person;
}