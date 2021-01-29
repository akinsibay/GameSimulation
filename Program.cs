using Ask.Abstract;
using Ask.Concrete;
using Ask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ask
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() {Id=1, Name = "CoD" };
            Player player1 = new Player() {FirstName="Akin", Id=1, IdentityNo="12345", LastName="Sibay",FavGame=game1 };
            PlayerManager playerManager = new PlayerManager(new ArnisCheckManager());
            playerManager.Add(player1);
            playerManager.List();
            
            Console.ReadLine();
        }
    }
}
