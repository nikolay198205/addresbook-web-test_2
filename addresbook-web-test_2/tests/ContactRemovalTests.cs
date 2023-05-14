using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests //пространство именs
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.Remove(1);
            //тесты торопятся, надо немного доработать метод RemoveContact, чтобы он ждал появления сообщения о том, что контакт удалён
            //driver.SwitchTo().Alert().Accept();
            //driver.FindElement(By.CssSelector("div.msgbox"));
        }


    }
}
