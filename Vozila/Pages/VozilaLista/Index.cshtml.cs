using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vozila.Model;

namespace Vozila.Pages.VozilaLista
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Vozilo> Vozila { get; set; }
        
        public async Task OnGet()
        {
            Vozila = await _db.Vozilo.ToListAsync();
        }
    }
}
