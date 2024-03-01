using BlogLib;

namespace BlogTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void EmpInfo_ValidData_ShouldPassValidation()
        {
            // Arrange
            EmpInfo empInfo = new EmpInfo
            {
                Email = "ramya@gmail.com",
                Name = "Ramya",
                PassCode = 47955
            };
        }
    }
}