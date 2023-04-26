using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [SetUpFixture] // метод
    public class TestSuiteFixture
    {

        [SetUp]
        public void InitApplicationManager() // инициализация
        {
            ApplicationManager app = ApplicationManager.GetInstance(); // так как конструктор ApplicationManager уже приватный, то вместо конструктора будем обращаться к методу GetInstance

        }

        [TearDown]
        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Stop();
        }
    }
}
