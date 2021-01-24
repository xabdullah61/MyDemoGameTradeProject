using System;

namespace Game_kampOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            #region İstenilen 1.Görev 
            Player player1 = new Player()
            {
                PlayerName = "Abdullah",
                PlayerLastname = "Ağaoğlu",
                BirthdayYear = "1200",
                TcNo = "1111111"
            };

            Player player2 = new Player()
            {
                PlayerName = "Kerem"
                ,
                PlayerLastname = "Ağaoğlu",
                BirthdayYear = "1461",
                TcNo = "521545444444"
            };

            PlayerManagment playerManagment = new PlayerManagment();

            playerManagment.Delete(player1);
            playerManagment.Register(player2);
            playerManagment.Update(player1);
            Console.WriteLine("********************");
            #endregion
            //1.     Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği,
            // kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz.
            //(E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.
            //Bunu yapacak servisi simule etmeniz yeterlidir.)
            #region İstenilen 2.Görev
            SqlUserService sql = new SqlUserService();
            OracleUserService oracle = new OracleUserService();
            UserCheck userCheck = new UserCheck();


            UserServicesManagment userManagment = new UserServicesManagment();

            userManagment.UserCheck(sql); //burada kullanıcı kontorlünü istediğiniz yerde yapabilrsiniz
            userManagment.LoggerServices(oracle);//loglanacak yer : sql or oracle
            userManagment.UserCheck(userCheck);//sql oracle veya usercheckde kullamıcı kontrol edilebilir.
            #endregion

            //2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)
            #region İStenilen 3. Görev
            GameTradeManager gameTradeManager = new GameTradeManager();



            //3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
            Console.WriteLine("*=========================================*");
            Campaign campaign1 = new Campaign
            {
                CampaignType = "İndirim",
                CampaignName = "Sıcak Yaz",
                CampaignRatio = 0.25
            };
            Campaign campaign2 = new Campaign
            {
                CampaignType = "Bedava",
                CampaignName = "Ramazan Bayramı Özel",
                CampaignRatio = 1
            };
            CampaignManager campaignManager = new CampaignManager();

            campaignManager.CampaignAdd(campaign2);
            campaignManager.CampaignDeleted(campaign1);
            //ürün tanımlama
            Product product1 = new Product()
            {
                ProductName = "COD 8",
                ProductPrice = 1250,
            };
            Product product2 = new Product()
            {
                ProductName = "Gta 6",
                ProductPrice = 880,
            };
            #endregion
            //3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
            #region İstenilen 4. Görev
            Console.WriteLine("*==================================*");
            gameTradeManager.GameBuy(player1, product1, campaign1);
            gameTradeManager.GameSell(player2, product2, campaign2);
            #endregion
            //4.     Satışlarda kampanya entegrasyonunu simule ediniz.

        }
    }
}
