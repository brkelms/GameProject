using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameDB : CampaignsIdentity
    {
        public int GameId { get; set; }
        public string OyunAdi { get; set; }
        public string Fiyat { get; set; }
    }
}
