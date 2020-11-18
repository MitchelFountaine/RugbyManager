using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.RugbyTeamService;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RugbyTeamController : ControllerBase
    {
        private readonly IRugbyTeamService _rugbyTeamService;
        public RugbyTeamController(IRugbyTeamService rugbyTeamService)
        {
            _rugbyTeamService = rugbyTeamService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _rugbyTeamService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _rugbyTeamService.GetById(id));
        }

        [HttpPost("{teamId}")]
        public async Task<IActionResult> AddPlayerToTeam(int teamId, RugbyPlayer newPlayer)
        {
            return Ok(await _rugbyTeamService.AddPlayerToTeam(teamId, newPlayer));
        }
    }
}
