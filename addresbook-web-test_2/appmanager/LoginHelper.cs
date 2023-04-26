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
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                logout();

            }

            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);

            driver.FindElement(By.XPath("//input[@value='Login']")).Click(); // нажатие на кнопку
        }



        public void logout()
        {
            throw new NotImplementedException();
        }



        public bool IsLoggedIn()
        {
            throw new NotImplementedException();
        }

        public bool IsLoggedIn(AccountData account)
        {
            throw new NotImplementedException();
        }
    }
}
