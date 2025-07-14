using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; // Not directly used in the provided code, but often useful for dropdowns.
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor: Dependency Injection provides an instance of ApplicationDbContext.
        public InsureesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Insurees
        // This action displays a list of all Insurees.
        public async Task<IActionResult> Index()
        {
            // Retrieve all Insurees from the database asynchronously and pass them to the view.
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insurees/Details/5
        // This action displays the details of a specific Insuree based on their ID.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                // If no ID is provided in the URL, return a Not Found error (HTTP 404).
                return NotFound();
            }

            // Find the Insuree by their ID in the database.
            // FirstOrDefaultAsync returns the first element or a default value (null in this case)
            // if no element is found.
            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                // If no Insuree is found with the given ID, return Not Found.
                return NotFound();
            }

            // Pass the found Insuree object to the Details view.
            return View(insuree);
        }

        // GET: Insurees/Create
        // This action displays the form for creating a new Insuree.
        public IActionResult Create()
        {
            // Simply return the Create view to display the empty form to the user.
            return View();
        }

        // POST: Insurees/Create
        // This action handles the submission of the "Create" form.
        // [HttpPost] indicates this method handles POST requests.
        // [ValidateAntiForgeryToken] helps prevent cross-site request forgery attacks.
        // [Bind(...)] specifies which properties from the form should be bound to the Insuree object,
        // preventing overposting attacks. Note that 'Quote' is included here in Bind,
        // but its value will be overwritten by our calculation logic.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            // Check if the model state is valid based on data annotations (e.g., [Required])
            // in the Insuree model and other validation rules.
            if (ModelState.IsValid)
            {
                // --- Quote Calculation Logic ---
                // 1. Base Rate: Start with a base quote of $50.00 per month.
                decimal quote = 50.00m;

                // 2. Age Calculation: Determine the age of the insuree based on DateOfBirth.
                var today = DateTime.Today;
                var age = today.Year - insuree.DateOfBirth.Year;
                // Adjust age if the birthday for this year has not yet occurred.
                if (insuree.DateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }

                // Apply age-based surcharges.
                if (age <= 18)
                {
                    quote += 100.00m; // If age is 18 or less, add $100.00.
                }
                else if (age >= 19 && age <= 25)
                {
                    quote += 50.00m; // If age is between 19 and 25, add $50.00.
                }
                else // age > 25
                {
                    quote += 25.00m; // If age is 26 or more, add $25.00.
                }

                // 3. Car Year Surcharge: Apply surcharge for older or newer cars.
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote += 25.00m; // If car year is before 2000 or after 2015, add $25.00.
                }

                // 4. Car Make and Model Surcharge: Apply specific surcharges for certain car types.
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25.00m; // If CarMake is "Porsche", add $25.00.
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        quote += 25.00m; // If CarModel is "911 Carrera", add an additional $25.00.
                                         // (Total for this specific model will be $50.00).
                    }
                }

                // 5. DUI Surcharge: Apply a multiplier if the insuree has a DUI.
                if (insuree.DUI)
                {
                    quote *= 1.25m; // If DUI is true, increase the quote by 25%.
                }

                // 6. Speeding Tickets Surcharge: Add a fixed amount per speeding ticket.
                quote += (insuree.SpeedingTickets * 10.00m); // Add $10.00 for each speeding ticket.

                // 7. Coverage Type Surcharge: Apply a multiplier for full coverage.
                if (insuree.CoverageType) // If CoverageType is true (Full Coverage).
                {
                    quote *= 1.50m; // Increase the quote by 50%.
                }

                // Assign the calculated quote to the Insuree object's Quote property.
                insuree.Quote = quote;

                // Add the new Insuree object to the database context.
                _context.Add(insuree);
                // Save the changes to the database asynchronously.
                await _context.SaveChangesAsync();
                // Redirect to the Index action to display the list of Insurees, including the new one.
                return RedirectToAction(nameof(Index));
            }
            // If ModelState is not valid (e.g., required fields are empty),
            // return the view with the current Insuree object to display validation errors to the user.
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        // This action displays the form for editing an existing Insuree.
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // This action handles the submission of the "Edit" form.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Re-calculate the quote on edit to ensure consistency.
                    // This is important if you allow editing of fields that affect the quote.

                    decimal quote = 50.00m; // Base Rate

                    // Age Calculation
                    var today = DateTime.Today;
                    var age = today.Year - insuree.DateOfBirth.Year;
                    if (insuree.DateOfBirth.Date > today.AddYears(-age))
                    {
                        age--;
                    }

                    if (age <= 18)
                    {
                        quote += 100.00m;
                    }
                    else if (age >= 19 && age <= 25)
                    {
                        quote += 50.00m;
                    }
                    else
                    {
                        quote += 25.00m;
                    }

                    // Car Year
                    if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                    {
                        quote += 25.00m;
                    }

                    // Car Make
                    if (insuree.CarMake.ToLower() == "porsche")
                    {
                        quote += 25.00m;
                        if (insuree.CarModel.ToLower() == "911 carrera")
                        {
                            quote += 25.00m;
                        }
                    }

                    // DUI
                    if (insuree.DUI)
                    {
                        quote *= 1.25m;
                    }

                    // Speeding Tickets
                    quote += (insuree.SpeedingTickets * 10.00m);

                    // Coverage Type
                    if (insuree.CoverageType)
                    {
                        quote *= 1.50m;
                    }

                    insuree.Quote = quote; // Assign the recalculated quote

                    _context.Update(insuree); // Update the Insuree object in the database context.
                    await _context.SaveChangesAsync(); // Save the changes.
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Handles concurrency conflicts (e.g., if another user modified the same record).
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw; // Re-throw the exception if it's not a "not found" issue.
                    }
                }
                return RedirectToAction(nameof(Index)); // Redirect to the Index action.
            }
            return View(insuree); // If ModelState is invalid, return the view with validation errors.
        }

        // GET: Insurees/Delete/5
        // This action displays the confirmation page for deleting an Insuree.
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        // This action handles the deletion of an Insuree record.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree); // Remove the Insuree from the database context.
            }

            await _context.SaveChangesAsync(); // Save the changes to the database.
            return RedirectToAction(nameof(Index)); // Redirect to the Index action.
        }

        // Helper method to check if an Insuree exists by ID.
        private bool InsureeExists(int id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }

        // GET: Insurees/Admin
        // This new action displays all quotes along with user's name and email for admin purposes.
        public async Task<IActionResult> Admin()
        {
            // Retrieve all Insurees from the database asynchronously.
            // The view will then iterate through this list to display the required fields.
            var insurees = await _context.Insuree.ToListAsync();
            return View(insurees);
        }
    }
}