using NUnit.Framework;
using Main;

namespace MainTest
{
    public class Tests
    {
        [Test]
        public void TestGetProductName()
        {
            Product product = new Product(1, "Test", 20, 2);

            Assert.That(product.GetProductName() == "Test");
        }
        [Test]
        public void TestSetProductName()
        {
            Product product = new Product(1, "Test", 20, 2);
            product.SetProductName("NewTest");

            Assert.That(product.GetProductName() == "NewTest");
        }
        [Test]
        public void TestProductisEqual()
        {
            Product product1 = new Product(1, "Kiwi", 20, 2);
            Product product2 = new Product(2, "Kiwi", 20, 2);
            Assert.IsTrue(product1 == product2);
        }

    }
}