using NUnit.Framework;
using TestDemos.App;

namespace TestDemos.NUnitTest
{

    [TestFixture]
    public class BancAccountTest
    {
        [Test]
        public void CreatingBancAccountShouldSetInitialAmount()
        {
            BancAccount bancAccount = new BancAccount(2000);

            Assert.AreEqual(2000, bancAccount.Amount);
        }
    }
}