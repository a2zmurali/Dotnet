using Moq;
using Moq.AutoMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;

namespace UnitTest
{
    public class stdserviceTest
    {

        [Fact]
        public void Testsave_whennameisempty()
        {
            // Arrange
            string name = "";
            int age = 6;
            Studentrepo repo = new Studentrepo();
            stdservice obj = new stdservice(repo);

            //Act
            var id = obj.save(name, age);
                
            //Assert
            Assert.Equal(0, id);

        }

        [Fact]
        public void Testsave_whenageisempty()
        {
            // Arrange
            string name = "HI";
            int age = 0;
            Studentrepo repo = new Studentrepo();
            stdservice obj = new stdservice(repo);

            //Act
            Assert.Throws<Exception>(()=>obj.save(name, age));
        }

        [Fact]
        public void Testsave_whenNAvalid()
        {
            // Arrange
            string name = "HI";
            int age = 9;
            Studentrepo repo = new Studentrepo();
            stdservice obj = new stdservice(repo);
            //Act
            var id = obj.save(name, age);

            //Assert
            Assert.Equal(5, id);


        }

        [Fact]
        public void Testsave_Mock()
        {
            // Arrange
            string name = "HI";
            int age = 9;
            var mocker = new AutoMocker();
            var repo = mocker.GetMock<IStudentrepo>();            
            repo.Setup(x => x.saveDB(It.IsAny<student>())).Returns(100).Verifiable();

            //Act
            stdservice obj = mocker.CreateInstance<stdservice>();
            var id = obj.save(name, age);

            //Assert
            Assert.Equal(100, id);
        }
        [Fact]
        public void Testsave_Mock2()
        {
            // Arrange
            string name = "HI";
            int age = 9;
            var mocker = new AutoMocker();
            var repo = mocker.GetMock<IStudentrepo>();
            repo.Setup(x => x.saveDB(It.Is<student>(st => st.Name == "hi" && st.Age == age)))
                .Returns(101).Verifiable();
                
            //Act
            stdservice obj = mocker.CreateInstance<stdservice>();
            var id = obj.save(name, age);

            //Assert
            Assert.Equal(101, id);
            mocker.VerifyAll();
        }
    }
}
