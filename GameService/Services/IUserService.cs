using GameService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Services
{
    interface IUserService
    {
        Player AddPlayer(Player player);
        Player UpdatePlayer(Player player);
        Player GetPlayerByUsername(string userName);
        List<Player> GetPlayerByRaiting(double raiting);
    }
}
