using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Buy(Player player, Game game)
        {
            Console.WriteLine(player.Name +" " + game.Name + "oyununu satın aldı.");
        }

        public void Buy2(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine(player.Name +" " + game.Name + " " + campaign.Name + "oyununu kampanya uygulanarak satın aldı.");
        }
    }
}
