using Register.BlazorApp.Contracts.Repositories;
using Register.BlazorApp.Contracts.Services;
using Register.Shared.Domain;

namespace Register.BlazorApp.Services;

public class PersonDataService(IPersonRepository personRepository) : IPersonDataService
{
    public async Task<IEnumerable<Person>> GetAllPersonsAsync() =>
        await personRepository.GetAllPersons();

    public async Task<Person?> GetPersonByIdAsync(int personId) =>
        await personRepository.GetPersonById(personId);
}
