using DALForEF.Models;
using DALForEF.POCO;
using Model.HttpComunication;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using static Constans.URLApiAdress;
using static Constans.ConstansValues;

namespace DALForEF.Controllers
{
    [RoutePrefix(LogInEndpoint)]
    public class LogInController : ApiController
    {
        private readonly AuthService _authService;
        private readonly ContextDb _context;
        private readonly HeaderFilter _headerFilter;
        private readonly UsersService _service;
        public LogInController()
        {
            _authService = new AuthService();
            _context = new ContextDb();
            _headerFilter = new HeaderFilter();
            _service = new UsersService();
        }

        [HttpGet]
        [Route(LogInToSystem)]
        public IHttpActionResult LogInToApp()
        {
            var authorization = _authService.Authorize(Request);
            if (!authorization)
            {
                var result = Unauthorized();
                return result;
            }
            else
            {
                var users = _context.Users.ToList();
                var logIn = _headerFilter.GetHeader(Request.Headers, LogInHeader);
                var password = _headerFilter.GetHeader(Request.Headers, PasswordHeader);
                var autorisationResult = _service.AutoriseUser(users, logIn, password);
                return Ok(autorisationResult);
            }            
        }
    }
}