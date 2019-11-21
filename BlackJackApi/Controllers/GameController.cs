using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackApi.Core.Services.Interfaces;
using BlackJackApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJackApi.Controllers
{
    [Route("api/blackjack/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IDeckService _deckService;
        private readonly ICardService _cardService;
        private readonly IDealerService _dealerService;
        private readonly IPlayerService _playerService;

        public GameController(
            IGameService gameService,
            IDeckService deckService,
             ICardService cardService,
             IDealerService dealerService,
             IPlayerService playerService)
        {
            _gameService = gameService;
            _deckService = deckService;
            _cardService = cardService;
            _dealerService = dealerService;
            _playerService = playerService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("scores/{gameid}")]
        public async Task<IActionResult> Get(int gameid)
        {
          //Get game including delaer and player, calculate scores and send the ScoreDto

            //Return ScoreDto
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("new/{playerName}")]
        public async Task<IActionResult> Post(string playerName)
        {
            //Create Deck

            //Create Delaer

            //Create Player

            //Create Game

            //Return GameDto
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody]UpdateGameDto game)
        {
            //Get Game by Id

            //Update Game details
            return Ok();
        }
    }
}