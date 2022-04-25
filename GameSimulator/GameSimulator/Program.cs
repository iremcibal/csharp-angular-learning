using GameSimulator.Concrete;
using GameSimulator.Entities;
using System;

namespace GameSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player(1,"42898907581","İrem","Balcı",1999);
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.Save(NewPlayer1);

            Game NewGame1 = new Game();
            NewGame1.Name = "Pubg";
            NewGame1.Price = 400;

            Campaign NewCampaign = new Campaign();
            NewCampaign.Name = "Nisan Fırsatları";
            NewCampaign.Content = "%30 İndirim";

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(NewPlayer1, NewGame1);

            salesManager.Buy2(NewPlayer1, NewGame1, NewCampaign);

            Console.ReadLine();


        }
    } 
}
