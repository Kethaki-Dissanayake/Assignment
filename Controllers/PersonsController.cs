using AspNetCore;
using Assignment.Data;
using Assignment.Data.Services;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//..../Persons/Index

namespace Assignment.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonsService _service;

        public PersonsController(IPersonsService service)
        {
            _service= service;
        }

        public async Task<IActionResult> Index()
        {
           
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get : Persons/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePicture,FirstName,LastName,SSN,DOB")]Person person)
        {
            if(!ModelState.IsValid)
            {
                return View(person);
            }
            await _service.AddAsync(person);
            return RedirectToAction(nameof(Index));
        }

        //Get: Persons/Details/1

        public async Task<ActionResult> Details(int id)
        {
            var personDetails =await _service.GetByIdAsync(id);

            if (personDetails == null) return View("Not Found");
            return View(personDetails);
        }

        //Get : Persons/Update
        public async Task<IActionResult> Edit(int id)
        {
            var personDetails = await _service.GetByIdAsync(id);

            if (personDetails == null) return View("Not Found");
            
            return View(personDetails);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(int id, Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            await _service.UpdateAsync(id,person);
            return RedirectToAction(nameof(Index));
        }

        //Get : Persons/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var personDetails = await _service.GetByIdAsync(id);

            if (personDetails == null) return View("Not Found");

            return View(personDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personDetails = await _service.GetByIdAsync(id);

            if (personDetails == null) return View("Not Found");

            await _service.DeleteAsync(id);
            
            return RedirectToAction(nameof(Index));
        }
    }
}
