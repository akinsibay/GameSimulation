using Ask.Abstract;
using Ask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask.Concrete
{
    public class PlayerManager : IPlayerService
    {
        List<Player> players = new List<Player>();
        IValidationService _validationService;
        //Dependency Injection
        //BAK BURAYA
        public PlayerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Player player)
        {
            if (!_validationService.Validate(player))
            {
                Console.WriteLine(Message.Reject);
                Console.WriteLine();
            }
            else
            {
                players.Add(player);
            }

        }

        public void List()
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.Id + "  " + player.FirstName + " " + player.FavGame.Name);
            }
        }

        public void Remove(Player player)
        {
            players.Remove(player);
        }

        public void Update(int playerId, Player player)
        {
            Console.WriteLine("{0} Updated by {1}", playerId, player.Id);
        }
    }
}
