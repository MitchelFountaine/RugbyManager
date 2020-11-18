using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services.RugbyTeamService;

namespace Services.RugbyTeamService
{
    public class RugbyTeamService : IRugbyTeamService
    {
        private List<RugbyTeam> teams = new List<RugbyTeam>();

        public RugbyTeamService()
        {
            CreateTeams();
        }

        public async Task<List<RugbyTeam>> AddPlayerToTeam(int teamId, RugbyPlayer newPlayer)
        {
            RugbyTeam team = teams.FirstOrDefault(t => t.Id == teamId);
            teams.Remove(team);
            team.Players.Add(newPlayer);
            teams.Add(team);
            return teams;
        }

        public async Task<List<RugbyTeam>> GetAll()
        {
            return teams;
        }

        public async Task<RugbyTeam> GetById(int id)
        {
            return teams.FirstOrDefault(teams => teams.Id == id);
        }

        private void CreateTeams()
        {
            for (int i = 1; i < 4; i++)
            {
                if (i == 1)
                {
                    teams.Add(new RugbyTeam
                    {
                        Id = i,
                        Name = "Cheetahs",
                        Rank = i
                    });
                }
                else if(i == 2)
                {
                    teams.Add(new RugbyTeam
                    {
                        Id = i,
                        Name = "Bulls",
                        Rank = i,
                        Players = new List<RugbyPlayer>
                        {
                           new RugbyPlayer
                           {
                               Id=99,
                               Age=27,
                               Name = "Jacobus"
                           }
                        }
                    });
                }
                else
                {
                    teams.Add(new RugbyTeam
                    {
                        Id = i,
                        Name = "Lions",
                        Rank = i
                    });
                }
            }
        }
    }
}
