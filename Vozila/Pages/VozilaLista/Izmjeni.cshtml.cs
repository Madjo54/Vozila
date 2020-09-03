using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vozila.Model;

namespace Vozila.Pages.VozilaLista
{
    public class IzmjeniModel : PageModel
    {
        private AppDbContext _db;

        public IzmjeniModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Vozilo Vozilo { get; set;  }

        public async Task OnGet(int id)
        {

            Vozilo = await _db.Vozilo.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var VoziloFromDb = await _db.Vozilo.FindAsync(Vozilo.Id);
                VoziloFromDb.Model = Vozilo.Model;
                VoziloFromDb.Marka = Vozilo.Marka;
                VoziloFromDb.Tip = Vozilo.Tip;
                VoziloFromDb.Sasija = Vozilo.Sasija;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }

}
