using System;
using System.Collections.Generic;
using System.Text;

namespace Game_kampOdev
{
    class GameTradeManager
    {
       public void GameBuy(Player player,Product product,Campaign campaign)
        {
            product.ProductPrice = product.ProductPrice -(product.ProductPrice * campaign.CampaignRatio);
            Console.WriteLine(product.ProductPrice+"$       "+player.PlayerName+" adlı oyuncu bir oyun aldı.");
        }
        public void GameSell(Player player, Product product, Campaign campaign)
        {
            product.ProductPrice = product.ProductPrice -(product.ProductPrice * campaign.CampaignRatio);
            Console.WriteLine(product.ProductPrice + "$       " + player.PlayerName + " adlı oyuncu bir oyun Sattı.");
        }
    }
}
