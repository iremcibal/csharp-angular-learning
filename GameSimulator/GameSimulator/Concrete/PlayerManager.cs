using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Concrete
{
    
    internal class PlayerManager 
    {
        private IPlayerCheckService playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            this.playerCheckService = playerCheckService;
        }

        public void Save(Player player)
        {
            if (playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine("Oyuncu eklendi.");
            }
            else
            {
                throw new Exception("Gerçek kimlik ile giriş yapınız");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
