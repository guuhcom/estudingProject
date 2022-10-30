using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILogUsuario _logUsu;
        private readonly ISection _section;
        private readonly IHttpContextAccessor _httpContextAccessor;
        LoggerAgroX _loggerJeep = new LoggerAgroX();

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, ISection section, ILogUsuario logUsu)
        {
            _logger = logger;
            _logUsu = logUsu;
            _section = section;
            _httpContextAccessor = httpContextAccessor;
        }

        [Authorize(Roles = "1")]
        public IActionResult Index()
        {
            _logger.LogInformation(GetStringLogger("Index", "Index"));
            if (User.Identity.IsAuthenticated)
            {
                _logger.LogInformation(GetStringLoggerErro("Index", "Index", "A seção do usuário não foi autenticado."));
                return View();
            }
            return RedirectToAction("Index", "Account");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            _logger.LogInformation(GetStringLogger("Logout", "GET"));

            await HttpContext.SignOutAsync();

            _section.StatusSection(_httpContextAccessor.HttpContext.User.Identity.Name, false);
            return RedirectToAction("Index", "Account");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation(GetStringLogger("Error", "Error"));
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string GetStringLogger(string nameAction, string methodType, string parameters = null) =>
           (parameters != null) ? _loggerJeep.GetLoggerAction(nameAction, methodType, "HomeController", GetStringOfIdOfSection(), parameters) : _loggerJeep.GetLoggerAction(nameAction, methodType, "AccountController", GetStringOfIdOfSection());

        private string GetStringLoggerErro(string nameAction, string methodType, string messageOfError = null) =>
            (messageOfError != null) ? _loggerJeep.GetLoggerError(nameAction, methodType, "HomeController", GetStringOfIdOfSection(), messageOfError) : _loggerJeep.GetLoggerError(nameAction, methodType, "AccountController", GetStringOfIdOfSection());

        private string GetStringOfIdOfSection() => (string)_httpContextAccessor.HttpContext.User.Identity.Name.ToString();
    }
}
