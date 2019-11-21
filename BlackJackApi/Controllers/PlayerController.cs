using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackApi.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{gameid}/{deckid}")]
        public async Task<IActionResult> Get(int gameid, int deckid)
        {
            //Get Player including PlayerHandcards          

            //Return PlayerDto
            return Ok();
        }
    }
}