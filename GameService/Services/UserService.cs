using GameService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameService.Services
{
    internal class UserService : IUserService
    {
        List<Player> _players;
        public UserService()
        {
            _players = new List<Player>();

            _players.Add(new Player
            {
                Id = 1,
                Raiting = 30,
                Username = "Destroyer"
            });

            _players.Add(new Player
            {
                Id = 2,
                Raiting = 30,
                Username = "salam"
            });

            _players.Add(new Player
            {
                Id = 3,
                Raiting = 40,
                Username = "Turan"
            });
        }
        public Player AddPlayer(Player player)
        {
            if (_players.FirstOrDefault(p => p.Username == player.Username) != null)  
            {
                throw new Exception("This player already exist");
            }
            _players.Add(player);
            return player;
        }

        public List<Player> GetPlayerByRaiting(double raiting)
        {
            return _players.Where(u => u.Raiting == raiting).ToList();
        }

        public Player? GetPlayerByUsername(string userName)
        {
            return _players.FirstOrDefault(u => u.Username == userName);
        }

        public Player UpdatePlayer(Player player)
        {
            Player playerToUpdate = _players.FirstOrDefault(p => p.Id == player.Id);

            playerToUpdate.Username = player.Username;
            playerToUpdate.Raiting = player.Raiting;

            return playerToUpdate;
        }
    }
}
