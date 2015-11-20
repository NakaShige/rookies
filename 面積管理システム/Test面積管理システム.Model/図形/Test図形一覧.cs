using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 面積管理システム.Model.図形;

namespace Test面積管理システム.Model.図形
{
    [TestClass]
    public class Test図形一覧
    {
        [TestMethod]
        public void TestAddRemove()
        {
            var figList = new 図形一覧();
            var triangle = new 三角形(2.0);
            figList.Add(triangle);
            var square = new 四角形(2.0);
            figList.Add(square);

            Assert.AreEqual(2, figList.Items.Length);

            figList.Remove(triangle);
            Assert.AreEqual(1, figList.Items.Length);
            figList.Remove(square);
            Assert.AreEqual(0, figList.Items.Length);
        }
    }
}
