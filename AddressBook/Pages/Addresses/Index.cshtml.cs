using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AddressBook.Data;
using AddressBook.Models;

namespace AddressBook.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly AddressBook.Data.AddressBookContext _context;

        public IndexModel(AddressBook.Data.AddressBookContext context)
        {
            _context = context;
        }
        //Searching by name
        [BindProperty(SupportsGet =true)]
        public string ? SearchName { get; set; }
        public SelectList ? Name { get; set; }
        [BindProperty (SupportsGet =true)]
        public string ? FirstName { get; set; }

        //searching by lastname
        [BindProperty(SupportsGet = true)]
        public string? SearchLastName { get; set; }
        public SelectList? LName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? LastName { get; set; }





        public IList<Users> Users { get;set; } = default!;

       

        public async Task OnGetAsync()
        {

            var users = from m in _context.Users
                        select m;




            if (!string.IsNullOrEmpty(SearchName))
            {
                users = users.Where(s => s.FirstName.Contains(SearchName));
            }

            if (!string.IsNullOrEmpty(SearchLastName))
            {
                users = users.Where(c => c.LastName.Contains(SearchLastName));
            }



            Users = await users.ToListAsync();

        }
        





    }
}
