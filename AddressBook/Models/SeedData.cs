namespace AddressBook.Models
{

    using Microsoft.EntityFrameworkCore;
    using AddressBook.Data;

    namespace AddressBookData.Models
    {
        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new AddressBookContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<AddressBookContext>>()))
                {
                    if (context == null || context.Users == null)
                    {
                        throw new ArgumentNullException("Null Address Book Context");
                    }

                    
                    if (context.Users.Any())
                    {
                        return;   
                    }

                    context.Users.AddRange(
                        new Users
                        {
                            FirstName = "Irena",
                            LastName = "Grill",
                            Address = "Gasilska 15a",
                            Telephone = 040375108
                        },

                        new Users
                        {
                            FirstName = "Matjaž",
                            LastName = "Gantar",
                            Address = "Majstrova 1",
                            Telephone = 031131657
                        },

                        new Users
                        {
                            FirstName = "Rok",
                            LastName = "Gates",
                            Address = "Silicon Valley 3",
                            Telephone = 356345867
                        },

                        new Users
                        {
                            FirstName = "Mojca",
                            LastName = "Potrinčič",
                            Address = "Zavrke 3",
                            Telephone = 123456789
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
   
}
