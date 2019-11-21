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
    public class DelaerController : ControllerBase
    {
        private readonly IDealerService _dealerService;

        public DelaerController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{gameid}/{deckid}")]
        public async Task<IActionResult> Get(int gameid, int deckid)
        {
            //Get Delaer including DealerHandcards          

            //Return DealerDto
            return Ok();
        }
    }
}