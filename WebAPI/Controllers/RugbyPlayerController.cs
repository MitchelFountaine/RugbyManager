using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.RugbyPlayerService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RugbyPlayerController : ControllerBase
    {
        private readonly IRugbyPlayerService _rugbyPlayerService;
        public RugbyPlayerController(IRugbyPlayerService rugbyPlayerService)
        {
            _rugbyPlayerService = rugbyPlayerService;
        }
        [HttpGet("GetAllAvailable")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _rugbyPlayerService.GetAllAvailable());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetSingle(int id)
        {
            return Ok(await _rugbyPlayerService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddRugbyPlayer(RugbyPlayer newPlayer)
        {
            return Ok(await _rugbyPlayerService.AddRugbyPlayer(newPlayer));
        }
    }
}
