using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigetionHelper : HelperBase
    {

        private string baseURL; // объявление поля адрес URL

        public NavigetionHelper(ApplicationManager manager, string baseURL) : base(manager)// конструктор для передачи адресов в driver
        {
            this.baseURL = baseURL; // 
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL) // проверка на то, что открыта страница групп (Для ДЗ)
            {
                return;
            }

            driver.Navigate().GoToUrl(baseURL);
        }



        public void GoToGroupsPage() // метод который осуществляет переход на страницу групп
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                &&
                IsElementPresent(By.Name("new"))) // проверка на то, что открыта страница групп (Для ДЗ)
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }





    }
}
