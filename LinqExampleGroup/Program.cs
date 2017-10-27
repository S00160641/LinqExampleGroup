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
    }
    class Program
    {
        List<Player> players = new List<Player>()
        {
            new Player { Id = Guid.NewGuid(), Name = "Pete Volga", Xp = 100 },
            new Player { Id = Guid.NewGuid(), Name = "Joe Bloggs", Xp = 200 },
            new Player { Id = Guid.NewGuid(), Name = "Pete Townsend", Xp = 150 },
            new Player { Id = Guid.NewGuid(), Name = "Mary Shelly", Xp = 180 },
            new Player { Id = Guid.NewGuid(), Name = "Jane Doe", Xp = 105 }
        };
        static void Main(string[] args)
        {
        }
    }
}
