using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager:IProjectManager<CampaignsDB>
    {
        public void Add(CampaignsDB campaigns)
        {
            Console.WriteLine(campaigns.Adi + " kampanyası sisteme eklendi.");
        }
        public void Delete(CampaignsDB campaigns)
        {
            Console.WriteLine(campaigns.Adi + " kampanyası sistemden silindi.");
        }
        public void Update(CampaignsDB campaigns)
        {
            Console.WriteLine(campaigns.Adi + " kampanyası güncellendi.");
        }
    }
}
