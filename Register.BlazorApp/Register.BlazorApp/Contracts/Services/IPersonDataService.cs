using Register.Shared.Domain;

namespace Register.BlazorApp.Contracts.Services;
public interface IPersonDataService
{
    Task<IEnumerable<Person>> GetAllPersonsAsync();
    Task<Person?> GetPersonByIdAsync(int personId);
}