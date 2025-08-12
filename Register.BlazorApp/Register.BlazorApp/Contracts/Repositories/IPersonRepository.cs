using Register.Shared.Domain;

namespace Register.BlazorApp.Contracts.Repositories;
public interface IPersonRepository
{
    Task<IEnumerable<Person>> GetAllPersons();
    Task<Person?> GetPersonById(int personId);
}