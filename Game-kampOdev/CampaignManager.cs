using System;
using System.Collections.Generic;
using System.Text;

namespace Game_kampOdev
{
    class CampaignManager
    {
        public void CampaignAdd(Campaign campaign)
        {
            
            Console.WriteLine(campaign.CampaignType+" ==>"+campaign.CampaignName+" adlı Kampanya Başladı");
        }
        public void CampaignDeleted(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignType + " ==>" + campaign.CampaignName + " adlı Kampanya bitti.");
        }
    }
}
