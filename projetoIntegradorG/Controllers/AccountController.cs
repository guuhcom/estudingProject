using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using projetoIntegrador.Context;
using projetoIntegrador.Models;
using projetoIntegrador.Models.Class;
using projetoIntegrador.Models.DbClass;
using projetoIntegrador.Repository.Interfaces;
using projetoIntegrador.Services.Authentication;
using projetoIntegrador.Services.SectionService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace projetoIntegrador.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthentication _authentication;
        private readonly AppDbContext _context;
        private readonly ISection _section;
        private readonly IUsuario _usuario;
        ILogger _logger;
        LoggerAgroX _loggerJeep = new LoggerAgroX();

        public AccountController(ILogger<AccountController> logger, IAuthentication authentication, AppDbContext context, ISection section, IUsuario usuario)
        {
            _authentication = authentication;
            _context = context;
            _section = section;
            _usuario = usuario;
            _logger = logger;
        }

        // GET: Account
        public async Task<IActionResult> Index()
        {
            ViewBag.ListCards = GetListCards();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation(GetStringLogger("Error", "GET"));
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logar([Bind] LoginViewModel lvm)
        {
            _logger.LogInformation(
                GetStringLogger(
                    "Logar",
                    "GET",
                    JsonConvert.SerializeObject(lvm)));

            try
            {
                ModelState.Remove("Url");

                int idCarteiraSelecionada = lvm.IdCarteira;
                Usuario user = CreateUser(lvm.Login, lvm.Password);

                List<Carteira> carteiras = GetListCards();
                ViewBag.ListCards = carteiras;

                if (!ModelState.IsValid)
                    return View("Index");

                if (IsValidUser(user))
                {
                    user = GetUsuario(lvm.Login);

                    if (idCarteiraSelecionada >= 0 && idCarteiraSelecionada <= carteiras.Count)
                    {
                        if (idCarteiraSelecionada == 0 && !IsValidUserAdmin(user))
                        {
                            TempData["LoginUsuarioFalhou"] = "O login informado não tem autorização para essa função";
                            return RedirectToAction("Index", "Account");
                        }

                        if (IsValidPassword(user, lvm.Password))
                        {
                            ClaimsPrincipal principal = CreatePrincipal(user, this.HttpContext.Session.Id);

                            await HttpContext.SignInAsync(principal);

                            this.HttpContext.Session.SetString("IdSec", this.HttpContext.Session.Id);

                            RegistreSection(user, this.HttpContext.Session.Id);

                            if (principal.Identity.IsAuthenticated)
                            {
                                switch (lvm.IdCarteira)
                                {
                                    case 0:
                                        return RedirectToAction("Index", "Admin", new { area = "Services" });
                                        break;
                                    case 1:
                                        return RedirectToAction("Index", "Home", new { area = "CruzeiroEsporteClube" });
                                        break;
                                    default:
                                        TempData["ErroPage"] = "A opção de carteira selecionada não foi encontrada ou ainda não foi implementada em nossa plataforma.";
                                        return RedirectToAction("Error", "Account");
                                        break;
                                }
                            }
                            else
                            {
                                TempData["LoginUsuarioFalhou"] = "O processo de login Falhou. " + principal.Identity.Name;
                                return RedirectToAction("Index", "Account");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogInformation(GetStringLoggerErro("Logar", "Logar", e.Message));
            }

            TempData["LoginUsuarioFalhou"] = "O login Falhou. Informe as credenciais corretas  e a senha";
            return View("Index", lvm);
        }

        private string GetStringLogger(string nameAction, string methodType, string parameters = null) =>
            (parameters != null) ? _loggerJeep.GetLoggerAction(nameAction, methodType, "AccountController", parameters) : _loggerJeep.GetLoggerAction(nameAction, methodType, "AccountController");

        private string GetStringLoggerErro(string nameAction, string methodType, string messageOfError = null) =>
            (messageOfError != null) ? _loggerJeep.GetLoggerError(nameAction, methodType, "AccountController", messageOfError) : _loggerJeep.GetLoggerError(nameAction, methodType, "AccountController");

        private ClaimsPrincipal CreatePrincipal(Usuario user, string keySection)
        {
            var principal = new ClaimsPrincipal(CreateClaimsIdentity(CreateClaims(keySection, user.IDNIV_USU.ToString())));

            Thread.CurrentPrincipal = principal;
            return principal;
        }

        private List<Claim> CreateClaims(string keySection, string idLevelUser) => new List<Claim>() { new Claim(ClaimTypes.Name, keySection), new Claim(ClaimTypes.Role, idLevelUser) };

        private ClaimsIdentity CreateClaimsIdentity(List<Claim> claims) => new ClaimsIdentity(claims, "User");

        private void RegistreSection(Usuario user, string keySection) => _section.InsertSection(user, keySection);

        private List<Carteira> GetListCards() => _context.Carteiras.ToList();

        private Usuario CreateUser(string login, string password) => new Usuario() { MATRICULA_USU = Int32.Parse(login), SENHA_USU = password.Trim() };

        private Usuario GetUsuario(string login) => (Usuario)_usuario.GetUsuarioByMatricula(Int32.Parse(login.Trim()));

        private bool IsValidUser(Usuario user) => _authentication.ValidateUser(user);

        private bool IsValidUserAdmin(Usuario user) => _authentication.ValidateAdmin(user);

        private bool IsValidPassword(Usuario user, string password)
        {
            var reverseRegistration = new string(password.Reverse().ToArray());
            return (reverseRegistration == user.MATRICULA_USU.ToString()) ? true : false;
        }

        private bool IsValidCard(int idCard) => _authentication.ValidateCard(idCard);
    }
}
