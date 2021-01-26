using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        public void Sales(PlayersDB player, GameDB game)
        {
            Console.WriteLine(player.Adi +" adlı oyuncu "+ game.OyunAdi+" adlı oyunu "+ game.Fiyat+" liraya satın aldı.");
        }
        public void SalesCancel(PlayersDB player, GameDB game)
        {
            Console.WriteLine(player.Adi + " adlı oyuncu " + game.OyunAdi + " adlı oyunu satın almaktan vazgeçti.");
        }



    }
}
