using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Models;
using Vidracaria_Portal.ViewModel;

namespace Vidracaria_Portal.Controllers
{
    public class AccountController : Controller
    {
        // Criar os gerenciadores, Login, usuario, perfil
        private readonly UserManager<UsuarioModel> userManager; // Usuario
        private readonly SignInManager<UsuarioModel> signInManager; //Login
        private readonly RoleManager<IdentityRole> roleManager; // perfil

        // Injetar dependecias dos metodos acima
        public AccountController(UserManager<UsuarioModel> user, SignInManager<UsuarioModel> sign, RoleManager<IdentityRole> role) //ctor - metodo construtor
        {
            userManager = user;
            signInManager = sign;
            roleManager = role;

        }

        public IActionResult Login()
        {
            return View();
        }


        // Segurança Login
        [HttpPost]
        [ValidateAntiForgeryToken] // Valida as chaves criadas para evitar ataque
        public async Task<IActionResult> Login(LoginViewModel userModel, string returnUrl = null)
        {
            // Obrigatorio
            if (!ModelState.IsValid) // Verifica se chegou os dados do login da page
            {
                return View(userModel);
            }

            // login    //lockoutOnFailure: true - se errar bloqueia o user com as option do startup                                                                                                        
            var result = await signInManager.PasswordSignInAsync(userModel.Email, userModel.Senha, userModel.Manter, lockoutOnFailure: true); // Pega a senha e o email e bate no banco
            if (result.Succeeded) // Se for um sucesso ele loga
            {
                // retorna o usuario pelo email
                var user = await userManager.FindByEmailAsync(userModel.Email);

                // retornas os perfis dos ususarios
                var roles = await userManager.GetRolesAsync(user);
                if (roles.Contains("Administrador"))
                    return RedirectToAction("Home", "Administrador");
                return RedirectToAction(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "E-mail de acesso e/ou senha invalido");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout() // Sair
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Home", "Home");
        }
    }
}
