using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class MemberManager:IProjectManager<PlayersDB>
    {
        public void Add(PlayersDB player)
        {
            AuthenticationManager kimlikKontrol = new AuthenticationManager();
            if (kimlikKontrol.Dogrula(player) == true)
            {
                Console.WriteLine(player.Adi + " adlı oyuncu sisteme eklendi.");
            }
            else
                Console.WriteLine("Kimlik doğrulanamadığı için işlem gerçekleştirilemedi!");
        }

        public void Delete(PlayersDB player)
        {
            Console.WriteLine(player.Adi + " adlı oyuncu silindi.");
        }

        public void Update(PlayersDB player)
        {
            Console.WriteLine(player.TcNo + " kimlik numaralı kullanıcının bilgileri güncellendi.");
        }
    }
}
