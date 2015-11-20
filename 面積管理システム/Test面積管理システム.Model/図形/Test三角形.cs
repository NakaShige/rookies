using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 面積管理システム.Model.図形;

namespace Test面積管理システム.Model.図形
{
    [TestClass]
    public class Test三角形
    {
        [TestMethod]
        public void Test辺の長さが正()
        {
            var triangle = new 三角形(2.0);
            Assert.AreEqual("三角形", triangle.Name);
            Assert.AreEqual(2.0, triangle.辺の長さ);
            Assert.AreEqual(1.7320508075689, triangle.面積, 3);
        }

        [TestMethod]
        public void Test辺の長さが０()
        {
            var triangle = new 三角形(0.0);
            Assert.AreEqual("三角形", triangle.Name);
            Assert.AreEqual(0.0, triangle.辺の長さ);
            Assert.AreEqual(0.0, triangle.面積, 3);
        }

        [TestMethod]
        public void Test辺の長さが負()
        {
            var triangle = new 三角形(-2.0);
            Assert.AreEqual("三角形", triangle.Name);
            Assert.AreEqual(0.0, triangle.辺の長さ);
            Assert.AreEqual(0.0, triangle.面積, 3);
        }
    }
}
