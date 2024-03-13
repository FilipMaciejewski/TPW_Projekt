namespace TestProjekt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32 a = 2;
            Int32 b = 3;
            Int32 c = 5;
            if(c == a + b)
            {
                Console.WriteLine("Valid");
            }
        }
    }
}