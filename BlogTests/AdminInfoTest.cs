using BlogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTests
{
    [TestFixture]
    public class AdminInfoTest
    {
        [TestCase]
        public void EmailId()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("banala@gmail.com", "banala@gmail.com");
        }

        [TestCase]
        public void Password()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("banala@123", "banala@123");
        }
    }
}
