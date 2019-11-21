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
    public class DeckController : ControllerBase
    {
        private readonly IDeckService _deckService;

        public DeckController(IDeckService deckService)
        {           
            _deckService = deckService;           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{deckid}/delaer/draw")]
        public async Task<IActionResult> DrawDelaer(int deckid)
        {
            //Get Deck including Deckcards, select number cards equal to count parameter and update the IsDrawn field to true,
            //so that the card won't be drawn next time

            //Add the two cards to the dealerhand

            //Return CardDto
            return Ok();
        }

        [HttpGet("{deckid}/player/draw")]
        public async Task<IActionResult> DrawPlayer(int deckid)
        {
            //Get Deck including Deckcards, select number cards equal to count parameter and update the IsDrawn field to true,
            //so that the card won't be drawn next time

            //Add the two cards to the playerhand

            //Return CardDto
            return Ok();
        }
    }
}