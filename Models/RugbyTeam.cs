using System;
using System.Collections.Generic;

namespace Models
{
    public class RugbyTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RugbyPlayer> Players { get; set; } = new List<RugbyPlayer>();
        public int Rank { get; set; }
    }
}
