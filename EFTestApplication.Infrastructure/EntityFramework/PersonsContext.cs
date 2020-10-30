using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Microsoft.EntityFrameworkCore;

namespace EFTestApplication.Infrastructure.EntityFramework
{
    public class PersonsContext : DbContext
    {
        public const string DefaultSchemaName = "Persons";

        public PersonsContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema(DefaultSchemaName);
        }

        public async Task<List<Person>> GetPersons()
        {
            return await Set<Person>().ToListAsync();
        }

        public void AddPerson(Person person)
        {
            Set<Person>().Add(person);
        }
    }
}