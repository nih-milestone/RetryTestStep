namespace UnitTests
{
    [TestClass]
    public class RerunFailingTests
    {
        [TestMethod]
        public void TestThatSucceedsOnEverySecondRun()
        {
            bool pass = false;
            if (File.Exists("test_already_executed.txt"))
            {
                pass = true;
                File.Delete("test_already_executed.txt");
            }
            else
            {
                File.WriteAllText("test_already_executed.txt", "test");
            }

            Assert.IsTrue(pass);
        }
    }
}