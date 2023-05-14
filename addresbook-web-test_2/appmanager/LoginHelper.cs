using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using static System.Net.Mime.MediaTypeNames;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        //private ApplicationManager manager; //пока не понял нужно это тут или нет???

        public LoginHelper(ApplicationManager manager) : base(manager)// конструктор для передачи адресов в driver
        {

        }


        public void Login(AccountData account) // метод. будем в него принимать один параметр типа AccountData
        {
           if (IsLoggedIn()) // если мы уже залогинены то 
            {
                if (IsLoggedIn(account)) // проверка залогинены ли мы с той учетной записью какой надо
                {
                    return;
                }
              
                Logout(); // а вот это - если залогинены под другой учетной записью, то выход из учетной записи

            }

            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);

            driver.FindElement(By.XPath("//input[@value='Login']")).Click(); // нажатие на кнопку
        }



        public void Logout() 
        {
            // он должен предварительно проверить что нужная ссылка есть
            if(IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click(); // клик по ссылке ЛОГАУТ

            }
            
        }



        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout")); //если есть элемент с именем logout то это признак того, что мы находимся в какой то сессии
           
        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn() // проверка что мы залогинены
                 && // И проверка сразу двух условий
                 driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
                 == "(" + account.Username + ")";// находим элемент с именем логаут, далее находим элемент b потом имя ползователя
            
        }
    }
}
