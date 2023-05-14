using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture] //атрибут чтобы класс был признан NUnit в качестве тестового
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials() // логирование с валидными данными

        {
            // подготовка тестовой ситуации
            app.Auth.Logout(); // перед выполнением нужно сделать логаут

            //действие
            AccountData account = new AccountData("admin", "secret");//вынесем тестовые данные в переменную
            app.Auth.Login(account);
            
            //проверка
           Assert.IsTrue(app.Auth.IsLoggedIn(account)); // проверка
        }


        [Test]
        public void LoginWithInvalidCredentials() // логирование с НЕ валидными данными

        {
            // подготовка тестовой ситуации
            app.Auth.Logout(); // перед выполнением нужно сделать логаут

            //действие
            AccountData account = new AccountData("admin", "123");//вынесем тестовые данные в переменную
            app.Auth.Login(account);

            //проверка
            Assert.IsFalse(app.Auth.IsLoggedIn(account)); // проверка
        }
    }
}
