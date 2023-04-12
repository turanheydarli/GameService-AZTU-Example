using GameService.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public double Raiting { get; set; }
        public UserLigs Lig
        {
            get
            {
                if (Raiting > 90)
                {
                    return UserLigs.Gold;
                }
                else if (Raiting <= 60)
                {
                    return UserLigs.Bronze;
                }
                else if (Raiting <= 90)
                {
                    return UserLigs.Sliver;
                }
                else
                {
                    return UserLigs.Trash;
                }
            }
        }

    }
}
