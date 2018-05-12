using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentBackend.Common.Logic;
using StudentBackend.Common.Logic.Contracts;
using StudentBackend.Repository.Logic;
using StudentBackend.Repository.Logic.Contracts;
using StudentBackend.Repository.Logic.DataBaseContext;

namespace UnitTestProject.Repsoitory.Logic
{
    [TestClass]
    public class UnitTest1
    {
        StudentContext context;
        IMyLog logger;

        [TestInitialize()]
        public void Initialize()
        {
            context = new StudentContext();
        }

        [TestCleanup()]
        public void CleanUp()
        {
            
        }

        [DataRow("J", "E")]
        [TestMethod]
        public void Add()
        {
            IStudentRepository studentrepository = new StudentRepository(context, logger);

            Student st1 = new Student();

            studentrepository.Add(st1);

            Assert.IsTrue(st1.Equals(st1));


        }
    }
}
