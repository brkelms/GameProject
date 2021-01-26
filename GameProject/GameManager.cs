using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IProjectManager<GameDB>
    {
        public void Add(GameDB game)
        {
            Console.WriteLine(game.OyunAdi + " adlı oyun sisteme eklendi.");
        }
        public void Delete(GameDB game)
        {
            Console.WriteLine(game.OyunAdi + " adlı oyun sistemden silindi.");
        }
        public void Update(GameDB game)
        {
            Console.WriteLine(game.OyunAdi + " adlı oyun güncellendi.");
        }
    }
}
