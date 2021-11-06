using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSI_WebApp.Data;
using SSI_WebApp.Data.Enums;
using SSI_WebApp.Data.ViewModels;
using SSI_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSI_WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;

        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Users()
        {
            var data = await GetList();
            ViewData["ViewName"] = "Users-users";
            return View(data);
        }

        public async Task<IActionResult> Admins()
        {
            var data = await GetList();
            ViewData["ViewName"] = "Users-admins";
            return View(data);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            ViewData["ViewName"] = "Users-admins";

            if (user == null) return View("Error");

            return View(user);
        }

        public IActionResult Create()
        {
            ViewData["ViewName"] = "Users-admins";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserVM createUserVM)
        {
            if (!ModelState.IsValid) return View(createUserVM);

            var user = await _userManager.FindByEmailAsync(createUserVM.Email);
            var userByName = await _userManager.FindByNameAsync(createUserVM.UserName);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(createUserVM);
            }

            if (user != null )
            {
                TempData["Error"] = "This user name is already in use";
                return View(createUserVM);
            }

            var newUser = new ApplicationUser()
            {
                FullName = createUserVM.FullName,
                UserName = createUserVM.UserName,
                Email = createUserVM.Email,
                PhoneNumber = createUserVM.PhoneNumber,
                StreetName = createUserVM.StreetName,
                StateName = createUserVM.StateName,
                CityName = createUserVM.CityName,
                ZipCode = createUserVM.ZipCode,
                ProfilePicture = createUserVM.ProfilePicture
            };

            var newUserResponse = await _userManager.CreateAsync(newUser, createUserVM.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.Admin);

            return RedirectToAction("Admins");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ApplicationUser user)
        {
            //if (!ModelState.IsValid) return View(user);

            var currentUser = await _userManager.FindByIdAsync(user.Id);
            currentUser.FullName = user.FullName;
            currentUser.UserName = user.UserName;
            currentUser.Email = user.Email;
            currentUser.PhoneNumber = user.PhoneNumber;
            currentUser.StreetName = user.StreetName;
            currentUser.StateName = user.StateName;
            currentUser.CityName = user.CityName;
            currentUser.ZipCode = user.ZipCode;
            currentUser.ProfilePicture = user.ProfilePicture;

            await _userManager.UpdateAsync(currentUser);
            return RedirectToAction("Admins");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(user);
            return RedirectToAction("Admins");
        }

        public async Task<IActionResult> Details(string id)
        {
            var data = await _userManager.FindByIdAsync(id);

            if (data == null) return View("Error");

            var role = await _userManager.GetRolesAsync(data);

            if (role.Contains("Admin")) ViewData["ViewName"] = "Users-admins";
            if (role.Contains("User")) ViewData["ViewName"] = "Users-users";

            return View(data);
        }

        private async Task<UserDisplayVM> GetList()
        {
            var users = await(from user in _context.Users
                              join userRole in _context.UserRoles
                              on user.Id equals userRole.UserId
                              join role in _context.Roles
                              on userRole.RoleId equals role.Id
                              where role.Name == "User"
                              select user)
                                 .ToListAsync();
            var admins = await(from user in _context.Users
                               join userRole in _context.UserRoles
                               on user.Id equals userRole.UserId
                               join role in _context.Roles
                               on userRole.RoleId equals role.Id
                               where role.Name == "Admin"
                               select user)
                                 .ToListAsync();
            ViewData["ViewName"] = "Users";

            return new UserDisplayVM() { Users = users, Admins = admins };
        }
    }
}
