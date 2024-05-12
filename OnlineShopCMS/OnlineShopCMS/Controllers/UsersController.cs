using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Areas.Identity.Data;
using OnlineShopCMS.Data;
using OnlineShopCMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCMS.Controllers
{
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<OnlineShopUser> _userManager;
        private readonly OnlineShopUserContext _context;

        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<OnlineShopUser> userManager, OnlineShopUserContext context) 
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
            this._context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        public IActionResult Create()
        {
            var model = new RegisterViewModel();
            ViewData["Title"] = "註冊";
            model.ReturnUrl = "/";

           

            model.ExternalLogins = new List<AuthenticationScheme>();

          

      
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new OnlineShopUser
                {
                    UserName = model.Input.Email,
                    Email = model.Input.Email,
                    Name = model.Input.Name,
                    DOB = model.Input.DOB,
                   
                };

                var result = await _userManager.CreateAsync(user, model.Input.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Administrator");

                    return RedirectToAction("ListAdministrator", "Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // 如果模型無效，返回帶有錯誤的模型
            return View(model);
        }


        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole(OnlineShopUserRole role)
        {
            var roleExist = await _roleManager.RoleExistsAsync(role.RoleName);
            if (!roleExist)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(role.RoleName));
            }
            return View("ListRoles");
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);
            ViewBag.users = usersInRole;

            return View(role);
        }




        [HttpPost]
        public async Task<IActionResult> EditRole(IdentityRole role)
        {
            if (role == null)
            {
                return NotFound();
            }
            else
            {
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> ListUsers()
        {
            List<OnlineShopUserViewModel> userViewModels = new List<OnlineShopUserViewModel>();
            var AllUsers = _userManager.Users.ToList();
            foreach (var user in AllUsers)
            {
                userViewModels.Add(new OnlineShopUserViewModel
                {
                    User = user,
                    RoleName = string.Join("", await _userManager.GetRolesAsync(user))
                });
            }

            return View(userViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> ListAdministrator()
        {
            List<OnlineShopUserViewModel> administratorViewModels = new List<OnlineShopUserViewModel>();
            var administrators = await _userManager.GetUsersInRoleAsync("Administrator");

            foreach (var user in administrators)
            {
                administratorViewModels.Add(new OnlineShopUserViewModel
                {
                    User = user,
                    RoleName = "Administrator", // 因為已經確定是 Administrator 角色
                    Name=user.Name,
                    DOB=user.DOB,
                    Gender=user.Gender,
                    RegistrationDate=user.RegistrationDate

                  
                });
            }

            return View("ListAdministrator", administratorViewModels);
        }



        [HttpGet]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("ListUsers");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View("ListUsers");

        }

    }
}
