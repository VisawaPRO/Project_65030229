using Project_65030229;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProjectMembersCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
        [TestMethod]
        public void TestProjectMemberIds()
        {
            Assert.IsTrue((int)Project.Members.Phet == 1);
            Assert.IsTrue((int)Project.Members.Kla == 2);
            Assert.IsTrue((int)Project.Members.Mag == 3);
            Assert.IsTrue((int)Project.Members.Beck == 4);
        }
    }
}