using WebApplication3;

namespace UnitTest
{
    public class calTest
    {
        [Fact]
        public void Add2number()
        {
            // Arrange
            int a = 5 , b = 6 ;
            //Act
            int c = cal.add(a,b);
            //Assert
            Assert.Equal(11,c);
        }
        [Fact]
        public void Add2numberN()
        {
            // Arrange
            int a = -5, b = -6;
            //Act
            int c = cal.add(a, b);
            //Assert
            Assert.Equal(-11, c);
        }
        [Fact]
        public void Add2number1N()
        {
            // Arrange
            int a = 5, b = -6;
            //Act
            int c = cal.add(a, b);
            //Assert
            Assert.Equal(-1, c);
        }
    }
}