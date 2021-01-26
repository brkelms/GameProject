using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersDB player1 = new PlayersDB();
            player1.Adi = "Burak";
            player1.Soyadi = "Elmas";
            player1.TcNo = "11239058561";
            player1.DYili = "1995";
           
            PlayersDB player2 = new PlayersDB();
            player2.Adi = "Ahmet";
            player2.Soyadi = "Sevinç";
            player2.TcNo = "11232658561";
            player2.DYili = "1975";

            PlayersDB player3 = new PlayersDB();
            player3.Adi = "Seda";
            player3.Soyadi = "Pınar";
            player3.TcNo = "1123265851";
            player3.DYili = "1995";

            MemberManager memberManager = new MemberManager();
            Console.WriteLine("--Üye İşlemleri--");
            Console.WriteLine(" ");
            memberManager.Add(player1);
            memberManager.Add(player3);
            memberManager.Delete(player2);
            memberManager.Update(player1);

            CampaignsDB campaign1 = new CampaignsDB();
            campaign1.CampaignId = 1;
            campaign1.Adi = "Yılbaşı";
            campaign1.SonGunu = "5 Ocak 2021";

            CampaignsDB campaign2 = new CampaignsDB();
            campaign2.CampaignId = 2;
            campaign2.Adi = "Muhteşem Cuma";
            campaign2.SonGunu = "15 Mart 2021";

            CampaignsDB campaign3 = new CampaignsDB();
            campaign3.CampaignId = 3;
            campaign3.Adi = "Şahane Ocak";
            campaign3.SonGunu = "30 Ocak 2021";

            CampaignManager campaignManager = new CampaignManager();
            Console.WriteLine(" ");
            Console.WriteLine("--Kampanya İşlemleri--");
            Console.WriteLine(" ");
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            GameDB game1 = new GameDB();
            game1.GameId = 678;
            game1.OyunAdi = "Call Of Duty";
            game1.Fiyat = "400";
            game1.CampaignId = 2;

            GameDB game2 = new GameDB();
            game2.GameId = 452;
            game2.OyunAdi = "Civilizations 5";
            game2.Fiyat = "80";
            game2.CampaignId = 1;

            GameManager gameManager = new GameManager();
            Console.WriteLine(" ");
            Console.WriteLine("--Oyun İşlemleri--");
            Console.WriteLine(" ");
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game1);

            SalesManager salesManager = new SalesManager();
            Console.WriteLine(" ");
            Console.WriteLine("--Satış İşlemleri--");
            Console.WriteLine(" ");
            salesManager.Sales(player1,game1);
            salesManager.SalesCancel(player2,game2);





        }
    }
}
