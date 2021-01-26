using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class AuthenticationManager
    {
        bool sonuc;
        public bool Dogrula(PlayersDB player)
        {
            if (player.TcNo.Length == 11)
            {
                sonuc = true;
                return sonuc;
            }
            else
            {
                sonuc = false;
                return sonuc;
            }
        }
    }
}

