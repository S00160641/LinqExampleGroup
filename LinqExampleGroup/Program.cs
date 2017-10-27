using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExampleGroup
{
    public class Player
    {
        Guid _id;
        string _name;
        int _xp;

        public Guid Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Xp
        {
            get
            {
                return _xp;
            }

            set
            {
                _xp = value;
            }
        }

        public override string ToString()
        {
            return _id.ToString() + " " + _name.ToString() + " " + _xp.ToString();
        }
    }
    class Program
    {
        static List<Player> players = new List<Player>()
        {
            new Player { Id = Guid.NewGuid(), Name = "Pete Volga", Xp = 100 },
            new Player { Id = Guid.NewGuid(), Name = "Joe Bloggs", Xp = 20 },
            new Player { Id = Guid.NewGuid(), Name = "Pete Townsend", Xp = 150 },
            new Player { Id = Guid.NewGuid(), Name = "Mary Shelly", Xp = 180 },
            new Player { Id = Guid.NewGuid(), Name = "Jane Doe", Xp = 105 }
        };
        static void Main(string[] args)
        {
            // Return the first occurance of the match or null
            Console.WriteLine("Jane Doe Stats:");
            Player found = players.FirstOrDefault(p => p.Name == "Jane Doe");
            if (found != null)
                Console.WriteLine("{0}", found.ToString());
            else
                Console.WriteLine("Player Not Found");

            Console.WriteLine();

            // Return the first occurance of the some records
            Console.WriteLine("Pete Stats:");
            Player matchPlayers = players.FirstOrDefault(p => p.Name.Contains("Pete"));
            if (matchPlayers != null)
                Console.WriteLine("First Found: {0}", matchPlayers.ToString());
            else
                Console.WriteLine("Player Not Found");

            Console.WriteLine();

            // Return all those with an XP value over 100
            Console.WriteLine("Top Players:");
            List<Player> topPlayers = players.Where(p => p.Xp > 100).ToList();

            if (topPlayers.Count > 0)
            {
                foreach (var item in topPlayers)
                {
                    Console.WriteLine("{0}", item.ToString());
                }
            }
            else
                Console.WriteLine("No Players with XP over 100");
            Console.WriteLine("");

            // Produce a ScoreBoard of Player Names and Scores
            Console.WriteLine("Score Board:");
            var ScoreBoard = players
                                .OrderByDescending(o => o.Xp)
                                .Select(scores => new { scores.Name, scores.Xp });

            foreach (var item in ScoreBoard)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Xp);
            }

            Console.ReadKey();
        }
    }
}
