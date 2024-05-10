using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(PlayerClass.Tank, "Ana");
            Player p2 = new Player(PlayerClass.Slayer, "Paulo");
            Player p3 = new Player(PlayerClass.Tank, "Ana");

            HashSet<Player> setOfPlayers = new HashSet<Player>() {p1, p2, p3};
            foreach (Player p in setOfPlayers)
                Console . WriteLine ($"{p.Name} is a {p. PClass}" );
        }
    }
}
