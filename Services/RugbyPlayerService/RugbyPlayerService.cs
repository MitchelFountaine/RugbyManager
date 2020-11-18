using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.RugbyPlayerService
{
    public class RugbyPlayerService : IRugbyPlayerService
    {
        public List<RugbyPlayer> availableRugbyPlayers = new List<RugbyPlayer>();
        public RugbyPlayerService()
        {
            CreateAvailablePlayers();
        }
        public async Task<List<RugbyPlayer>> AddRugbyPlayer(RugbyPlayer newPlayer)
        {
            availableRugbyPlayers.Add(newPlayer);
            return availableRugbyPlayers;
        }

        public async Task<List<RugbyPlayer>> GetAllAvailable()
        {
            return availableRugbyPlayers;
        }

        public async Task<RugbyPlayer> GetById(int id)
        {
            return availableRugbyPlayers.FirstOrDefault(predicate => predicate.Id == id);
        }

        private void CreateAvailablePlayers()
        {
            for (int i = 1; i < 21; i++)
            {
                availableRugbyPlayers.Add(new RugbyPlayer
                {
                    Age = 10 + i,
                    Id = i
                });
            }
        }

    }
}
