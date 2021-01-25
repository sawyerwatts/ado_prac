using NUnit.Framework;

namespace ADO.Test
{
    public class Tests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            this._calc = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(4, this._calc.Add(0, 4));
            Assert.AreEqual(4, this._calc.Add(1, 3));
            Assert.AreEqual(4, this._calc.Add(2, 2));
            Assert.AreEqual(4, this._calc.Add(3, 1));
            Assert.AreEqual(4, this._calc.Add(4, 0));
        }
    }
}