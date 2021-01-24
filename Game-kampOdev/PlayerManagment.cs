using System;
using System.Collections.Generic;
using System.Text;

namespace Game_kampOdev
{
    class PlayerManagment
    {
        public void Register(Player player)
        {
            Console.WriteLine("Şu kullanıcı =>"+player.PlayerName+" "+
                player.PlayerLastname+"****"+
                player.TcNo+"*****"+
                player.BirthdayYear+"  Eklendi.");
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Şu kullanıcı =>" + player.PlayerName + " " +
               player.PlayerLastname + "****" +
               player.TcNo + "*****" +
               player.BirthdayYear + "  Silindi.");
        }
        public void Update(Player player)
        {
            Console.WriteLine("Şu kullanıcıya ait =>" + player.PlayerName + " " +
               player.PlayerLastname + "****" +
               player.TcNo + "*****" +
               player.BirthdayYear + "  bilgiler güncellendi.");

        }
    }
}
