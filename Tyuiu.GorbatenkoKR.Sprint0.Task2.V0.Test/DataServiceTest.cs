using Tyuiu.GorbatenkoKR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GorbatenkoKR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Карина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Карина", res);
        }
    }
}
