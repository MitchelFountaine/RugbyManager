using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.RugbyPlayerService
{
    public interface IRugbyPlayerService
    {
        Task<List<RugbyPlayer>> GetAllAvailable();
        Task<RugbyPlayer> GetById(int id);
        Task<List<RugbyPlayer>> AddRugbyPlayer(RugbyPlayer newPlayer);
    }
}
