using XListOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInsert1()
        {
            XList a = new XList(10);

            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 0; i < 100; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            var b = a.GetList();
            Assert.IsTrue(Util.IsSorted(b));

            a.Clear();
        }

        [TestMethod]
        public void TestInsert2()
        {
            XList a = new XList(10);

            for (int i = 100; i > 0; i--)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 100; i > 0; i--)
            {
                Assert.IsTrue(a.Contains(i));
            }

            var b = a.GetList();
            Assert.IsTrue(Util.IsSorted(b));

            a.Clear();
        }

        [TestMethod]
        public void TestInsert3()
        {
            List<int> list = new List<int>() { 667, 591, 744, 680, 47, 451, 995, 52, 394, 849,
                807, 351, 58, 326, 189, 420, 417, 353, 826, 543 };

            XList a = new XList(10);

            a.AddRange(list);

            Assert.AreEqual(20, a.Count());

            foreach (var x in list)
            {
                Assert.IsTrue(a.Contains(x));
            }

            var b = a.GetList();
            Assert.IsTrue(Util.IsSorted(b));

            a.Clear();
        }

        [TestMethod]
        public void TestInsert4()
        {
            // Test Duplicates
            List<int> list = new List<int>() { 67, 67, 67, 43, 43, 43, 24, 24, 24, 103, 103, 103, 91, 91, 91,
                21, 21, 21, 72, 72, 72, 106, 106, 106 };

            XList a = new XList(10);

            a.AddRange(list);

            Assert.AreEqual(24, a.Count());

            foreach (var x in list)
            {
                Assert.IsTrue(a.Contains(x));
            }

            var b = a.GetList();
            Assert.IsTrue(Util.IsSorted(b));

            Assert.AreEqual(3, b.Count(x => x == 21));
            Assert.AreEqual(3, b.Count(x => x == 24));
            Assert.AreEqual(3, b.Count(x => x == 43));
            Assert.AreEqual(3, b.Count(x => x == 67));
            Assert.AreEqual(3, b.Count(x => x == 72));
            Assert.AreEqual(3, b.Count(x => x == 91));
            Assert.AreEqual(3, b.Count(x => x == 103));
            Assert.AreEqual(3, b.Count(x => x == 106));

            a.Clear();
        }


        [TestMethod]
        public void TestDelete1()
        {
            XList a = new XList(10);

            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 0; i < 100; i++)
            {
                a.Delete(i);
            }

            Assert.AreEqual(0, a.Count());

            for (int i = 0; i < 100; i++)
            {
                Assert.IsFalse(a.Contains(i));
            }

            a.Clear();
        }

        [TestMethod]
        public void TestDelete2()
        {
            List<int> list = new List<int>() { 3, 4, 5, 7, 9, 11, 13, 15, 28, 33, 45, 103 };

            XList a = new XList(10);

            a.AddRange(list);

            Assert.AreEqual(12, a.Count());

            a.Delete(4);
            a.Delete(11);
            a.Delete(21);
            a.Delete(45);

            Assert.AreEqual(9, a.Count());

            Assert.IsTrue(a.Contains(3));
            Assert.IsTrue(a.Contains(5));
            Assert.IsTrue(a.Contains(7));
            Assert.IsTrue(a.Contains(9));
            Assert.IsTrue(a.Contains(13));
            Assert.IsTrue(a.Contains(15));
            Assert.IsTrue(a.Contains(28));
            Assert.IsTrue(a.Contains(103));

            Assert.IsFalse(a.Contains(4));
            Assert.IsFalse(a.Contains(11));
            Assert.IsFalse(a.Contains(21));
            Assert.IsFalse(a.Contains(45));

            a.Clear();
        }


    }
}