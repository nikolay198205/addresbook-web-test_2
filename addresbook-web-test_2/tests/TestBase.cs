﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
        public ApplicationManager app;

        [SetUp]
        public void SetupAplicationManager() // метод для инициализации который инициализирует: драйвер, помошников и метод
                                             //и метод тердаун который останавливает драйвер в конце
        {
            //driver = new FirefoxDriver();
            //baseURL = "http://localhost/addressbook/";
            // verificationErrors = new StringBuilder();
            app = ApplicationManager.GetInstance(); // получаем доступ к тому единственному экземпляру, который хранится внутри ApplicationManager, который автоматически создается при первом обращении
            app.Auth.Login(new AccountData("admin", "secret"));



        }

    }
}