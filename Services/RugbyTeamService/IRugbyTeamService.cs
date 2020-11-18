using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.RugbyTeamService
{
    public interface IRugbyTeamService
    {
        Task<List<RugbyTeam>> GetAll();
        Task<RugbyTeam> GetById(int id);
        Task<List<RugbyTeam>> AddPlayerToTeam(int teamId, RugbyPlayer newPlayer);
    }
}
