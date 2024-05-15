using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    public class User
    {
        public string Nickname { get; set; }
        public int Score { get; set; }
        public User() { }
        public User(string nick, int points)
        { 
            Nickname = nick;
            Score = points;
        }
    }
}
