using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using EFTestApplication.Infrastructure.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EFTestApplication.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonsContextDbContextFactory _dbContextFactory;

        public PersonsController(PersonsContextDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        [HttpGet]
        public async Task<List<Person>> GetPersons()
        {
            using (var context = _dbContextFactory.GetContext())
            {
                return await context.GetPersons();
            }
        }

        [HttpPost]
        public async Task AddPerson([FromBody] Person person)
        {
            using (var context = _dbContextFactory.GetContext())
            {
                context.AddPerson(person);
                await context.SaveChangesAsync();
            }
        }
    }
}