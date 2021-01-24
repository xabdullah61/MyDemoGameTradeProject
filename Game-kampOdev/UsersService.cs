using System;
using System.Collections.Generic;
using System.Text;

namespace Game_kampOdev
{
    interface IUsersService
    {
        void CheckUser();      

    }
    interface ILoggerService
    {
        void LoggerService();

    }
    class UserCheck : IUsersService
    {
        public void CheckUser()
        {
            Console.WriteLine("Kullanıcı Kontrol edildi.");
        }

    }
    class SqlUserService : IUsersService, ILoggerService
    {
        public void CheckUser()
        {
            Console.WriteLine("Kullanıcı Sql de doğrulandı");
        }

        public void LoggerService()
        {
            Console.WriteLine("Sqle Loglandı");
        }
    }
    class OracleUserService : ILoggerService, IUsersService
    {
        public void CheckUser()
        {
            Console.WriteLine("Kullanıcı Oracleda doğrulandı");
        }

        public void LoggerService()
        {
            Console.WriteLine("Oracle a loglandı");
        }
    }

    class UserServicesManagment
    {
        public void UserCheck(IUsersService usersService)
        {
            usersService.CheckUser();
        }
        public void LoggerServices(ILoggerService loggerService)
        {
            loggerService.LoggerService();
        }
    }
}
