using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using SuperShop.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();
        }

        public async Task seedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GeTUserByEmailAsync("rafaalexandrecosta26@gmail.com");
            if(user == null)
            {
                user = new User
                {
                    FirstName = "Rafael",
                    LastName = "Costa",
                    Email = "rafaalexandrecosta26@gmail.com",
                    UserName = "rafaalexandrecosta26@gmail.com",
                    PhoneNumber = "1234567890",
                };
                var result = await _userHelper.AddUserAsync(user,"123456");
                if(result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeding");
                }
            }

            if (!_context.Products.Any())
            {
                AddProduct("Iphone X", user);
                AddProduct("Rato mickey", user);
                AddProduct("magic mouse ", user);
                AddProduct("Ipad mini", user);
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
                User = user,
            });
        }
    }
}
