using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ihatethisoptionalsomuch_2.Data;
using ihatethisoptionalsomuch_2.Models;

namespace ihatethisoptionalsomuch_2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly ihatethisoptionalsomuch_2.Data.ihatethisoptionalsomuch_2Context _context;

        public IndexModel(ihatethisoptionalsomuch_2.Data.ihatethisoptionalsomuch_2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
