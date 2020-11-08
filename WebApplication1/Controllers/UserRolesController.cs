using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = Roles.SuperAdminRole)]
    public class UserRolesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            var listaUsuarios = new List<UserRolesViewModel>();
            foreach (IdentityUser item in users)
            {
                var nuevoUsuario = new UserRolesViewModel
                {
                    UserId = item.Id,
                    User = item.UserName,
                    Email = item.Email,
                    Roles = new List<string>(await _userManager.GetRolesAsync(item))
                };

                listaUsuarios.Add(nuevoUsuario);
            }

            return View(listaUsuarios);
        }



        public async Task<IActionResult> ManageRoles(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"El usuario con el ID = {userId} no se encuentra.";
                return NotFound();
            }

            ViewBag.userId = user.Id;
            ViewBag.UserName = user.UserName;
            var managerRolesModel = new List<ManagerUserRolesViewModel>();
            foreach (IdentityRole role in _roleManager.Roles)
            {
                var usuarioRole = new ManagerUserRolesViewModel
                {
                    RoleId = role.Id,
                    Role = role.Name,
                    IsSelected = await _userManager.IsInRoleAsync(user, role.Name)
                };
                managerRolesModel.Add(usuarioRole);
            }
            return View(managerRolesModel);
        }

        [HttpPost]
        public async Task<IActionResult> ManageRoles(string userId, List<ManagerUserRolesViewModel> model)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, $"El usuario con el ID = {userId} no se encuentra.");
                return View();
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, $"No se pudo quitar los roles existentes del usuario.");
                return View();
            }

            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.IsSelected).Select(x => x.Role));
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, $"No se pudo agregar los roles nuevos al usuario.");
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}