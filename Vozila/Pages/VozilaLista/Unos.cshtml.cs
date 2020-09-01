using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vozila.Model;

namespace Vozila.Pages.VozilaLista
{
    public class UnosModel : PageModel
    {
        private readonly AppDbContext _db;

        public UnosModel(AppDbContext db)
        {
            _db = db;
        }

        public Vozilo Vozilo { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                await _db.Vozilo.AddAsync(vozilo);
                await _db.SaveChangesAsync();

                return RedirectToPage("UnosUspjesan");
            }
            else
            {
                return Page();
            }
        }
    }
}
