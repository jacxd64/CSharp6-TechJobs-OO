
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Equals(job2));
            Assert.AreEqual(1, job2.Id - job1.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester", "name issue");
            Assert.AreEqual(job3.EmployerName.Value, "ACME", "employer issue");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert", "employerlocation issue");
            Assert.AreEqual(job3.JobType.Value, "Quality control", "job type issue");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence", "core competancy issue");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
    }
}

