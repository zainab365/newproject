using newproject.Engine;

namespace Test.newproject.Engine
{
    public class TestMathFunctions
    {
        [Fact]
        public void Test_AddNumbers()
        {
            int result = MathFunctions.AddNumbers(2, 4);

            Assert.Equal(6, result);
            Assert.Equal(7, MathFunctions.AddNumbers(3, 4));
        }
    }
}