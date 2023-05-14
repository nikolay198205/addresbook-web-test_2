using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase // объявляем тесты наследниками AuthTestBase так как им нужен логин
    {

        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);

        }






    }
}
