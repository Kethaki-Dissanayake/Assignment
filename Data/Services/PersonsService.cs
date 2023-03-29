using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data.Services
{
    public class PersonsService : IPersonsService
    {
        private readonly AppDbContext _context;
        public PersonsService(AppDbContext context) {
            _context = context;
        }

        public async Task AddAsync(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Persons.FirstOrDefaultAsync(n => n.PersonId == id);
            _context.Persons.Remove(result);
            await _context.SaveChangesAsync();


        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            var result = await _context.Persons.ToListAsync();
            return result;
        }

        public async Task<Person> GetByIdAsync(int id)
        {
           var result = await _context.Persons.FirstOrDefaultAsync(n => n.PersonId== id);
           return result;
        }

        public async Task<Person> UpdateAsync(int id, Person newPerson)
        {
            _context.Update(newPerson);
            await _context.SaveChangesAsync();
            return newPerson;
        }
    }
}
