using Microsoft.EntityFrameworkCore;
using Register.BlazorApp.Contracts.Repositories;
using Register.BlazorApp.Data;
using Register.Shared.Domain;

namespace Register.BlazorApp.Repositories;

public class PersonRepository(ApplicationDbContext context) : IPersonRepository, IDisposable
{
    public async Task<IEnumerable<Person>> GetAllPersons() =>
        await context.Persons.ToListAsync();

    public async Task<Person?> GetPersonById(int personId) =>
        await context.Persons.FirstOrDefaultAsync(c => c.PersonId == personId);

    public void Dispose() => context.Dispose();
}
