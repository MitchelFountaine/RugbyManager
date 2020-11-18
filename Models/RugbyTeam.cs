using System;
using System.Collections.Generic;

namespace Models
{
    public class RugbyTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RugbyPlayer> Players { get; set; }
        public int Rank { get; set; }
    }
}
