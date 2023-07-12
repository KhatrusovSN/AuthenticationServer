using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AuthenticationServer.Controllers
{
    [ApiController]
    [Route("(controller)")]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        public UserController(ILogger logger)
        {
            _logger = logger;
            logger.WriteEvent("Сообщение о событии в программе");
            logger.WriteError("Сообщение об ошибки в программе");
        }

        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Sergey",
                LastName = "Khatrusov",
                Login = "KhatrusovSN",
                Password = "1234567890",
                Email = "Khatrusov@gmail.com"
            };
        }
    }
}
