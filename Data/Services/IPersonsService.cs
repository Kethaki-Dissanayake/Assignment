using Assignment.Models;

namespace Assignment.Data.Services
{
    public interface IPersonsService
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task <Person> GetByIdAsync(int id);
        Task AddAsync(Person person);
        Task<Person> UpdateAsync(int id, Person newPerson);
        Task DeleteAsync(int id);

    }
}
