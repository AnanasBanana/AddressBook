using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AddressBook.Data;
using AddressBook.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace AddressBook.Pages.Addresses
{
    public class CreateModel : PageModel
    {
        private readonly AddressBook.Data.AddressBookContext _context;

        public CreateModel(AddressBook.Data.AddressBookContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Users Users { get; set; }
        

        
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }
          
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
