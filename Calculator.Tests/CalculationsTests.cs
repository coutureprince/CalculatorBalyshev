using Xunit;

namespace Calculator.Tests
{
    public class CalculationsTests
    {
        [Fact]
        public void TestProcessStatement()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement(" ", " ");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("a", "a+a");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "-");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("a", "");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("", "999999999+1");
            Assert.Equal("EXCEEDED", result);
           

        }
        [Fact]
        public void TestSum()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement("", "8+9");
            Assert.Equal("17", result);
            result = calculation.ProcessStatement("", "10+13");
            Assert.Equal("23", result);
        }
      
        [Fact]
        public void TestSubtractResultNine()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement("", "7+2");
            Assert.Equal("9", result);
        }
                    
        [Fact]
        public void TestSubtractResultMinusOne()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement("", "4-5");
            Assert.Equal("-1", result);
        }
        [Fact]
        public void TestSubtractResultZero()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement("", "3--");
            Assert.Equal("0", result);
           
        }
        [Fact]
        public void TestDivide()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement("", "8/1");
            Assert.Equal("8", result);
            result = calculation.ProcessStatement("", "6/3");
            Assert.Equal("2", result);
            result = calculation.ProcessStatement("", "5/a");
            Assert.Equal("0", result);
            result = calculation.ProcessStatement("-", "30/2");
            Assert.Equal("-15", result);
            result = calculation.ProcessStatement("", "0/5");
            Assert.Equal("NOT ÷ 0", result);
           
        }
        
       
    }
}
