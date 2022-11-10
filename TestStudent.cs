using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentLib;
namespace StudentTest
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void addFirstStudent_Should_Success()
        {
            StudentService sr = new StudentService();
            Student std = new Student() { Id = 1, Name = "Huyen", Age = 20, Score = 8};
            
            bool status = sr.addStudent(std);
            int length = sr.size();
            Assert.IsTrue(status);
            Assert.AreEqual(1, length);
        }

        [TestMethod]
        public void addAduplicatStudentId_ShouldReturn_False()
        {
            StudentService sr = new StudentService();
            Student std1 = new Student() { Id = 1, Name = "Huyen", Age = 20, Score = 8 };
            Student std2 = new Student() { Id = 1, Name = "Huyen", Age = 20, Score = 8 };
            sr.addStudent(std1);
            bool status = sr.addStudent(std2);
            Assert.IsFalse(status);
        }

        [TestMethod]
        public void passingNullParemeter_ShuoldThrow_nullRefException()
        {
            StudentService sr = new StudentService();
            bool exceptionThrow = false;
            try
            {
                sr.addStudent(null);
            } catch (NullReferenceException)
            {
                exceptionThrow = true;
            }
            Assert.IsFalse(exceptionThrow);
        }
    }
}