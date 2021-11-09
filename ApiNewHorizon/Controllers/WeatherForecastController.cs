using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNewHorizon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<User> users = new List<User>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<User> List()
        {
            return users;
        }

        [HttpPost]
        public User Create(User userData)
        {
            // Receber o nome e cpf do corpo da requisicao
            // Criar o usuario baseado nessas informacoes
            // adicionar na lista de usuarios

            User user = new User(users.Count() + 1, userData.name, userData.cpf);
            users.Add(user);
            return user;
        }

        [HttpDelete("{id}")]
        public User Delete(int id)
        {
           User user = users.Find(user => user.id == id);
            if(user != null)
            {
                users.Remove(user);
                
            }
            return user;
        }


        [HttpPut("{id}")]
        public User Update(int id, User userData)
        {
            User user = users.Find(user => user.id == id);
            if (user != null)
            {
                user.cpf = userData.cpf;
                user.name = userData.name;

            }
            return user;
        }

        [HttpGet("{id}")]
        public User GetById(int id)
        {
            User user = users.Find(user => user.id == id);
            
            return user;
        }


    }
}
