using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// базовый класс для тестов, которые требуют вход в систему (нужно выполнять логин и пароль)

namespace WebAddressbookTests
{
    public class AuthTestBase : TestBase //наследуется от общего тестбейса
    {

        [SetUp]
        public void SetupLogin() // метод для инициализации который инициализирует: драйвер, помошников и метод
                                 //и метод тердаун который останавливает драйвер в конце
        {
            //driver = new FirefoxDriver();
            //baseURL = "http://localhost/addressbook/";
            // verificationErrors = new StringBuilder();
          
            app.Auth.Login(new AccountData("admin", "secret"));



        }
    }
}
