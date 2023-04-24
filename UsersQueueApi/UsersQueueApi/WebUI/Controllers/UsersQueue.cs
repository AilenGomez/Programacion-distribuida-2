using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using UsersQueueApi.Application.Commands;
using System.Collections;

namespace UsersQueueApi.WebUI.Controllers
{
    public class UsersQueueController : ApiController
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<UsersQueueController> _logger;
        public static Queue users = new Queue();
        public UsersQueueController(IConfiguration configuration, ILogger<UsersQueueController> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        /// <summary>
        /// Post a new user
        /// </summary>
        /// <response code="200">Devuelve el objeto userResponse</response>
        /// <response code="400">Error inesperado</response> 
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> User()
        {
            try
            {
                return Ok(await Mediator.Send(new UserCommand{ users = users }));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Delete the queue
        /// </summary>
        /// <response code="200">Devuelve true si la queue se elemino correctamente y false en caso contrario</response>
        /// <response code="400">Error inesperado</response> 
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteUsers()
        {
            try
            {
                return Ok(await Mediator.Send(new DeleteUsersCommand { users = users }));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
