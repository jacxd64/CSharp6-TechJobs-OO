
using System.Net.Http.Headers;

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

        Job jobWithEmptyFields = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

        //public static string expectedToString = "\n" +
            //"ID: " + job3.Id + "\n" +
            //"Name: Product tester\n" +
            //"Employer: ACME\n" +
            //"Location: Desert\n" +
            //"Position Type: Quality control\n" +
            //"Core Competency: Persistence\n";

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

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string jobString = job3.ToString();
            Assert.IsTrue(jobString.StartsWith(Environment.NewLine), $"Expected string to start with newline but got: {jobString}");
            Assert.IsTrue(jobString.EndsWith(Environment.NewLine), $"Expected string to end with newline but got: {jobString}");
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string expectedOutput = Environment.NewLine +
                                    "ID: " + job3.Id + Environment.NewLine +
                                    "Name: Product tester" + Environment.NewLine +
                                    "Employer: ACME" + Environment.NewLine +
                                    "Location: Desert" + Environment.NewLine +
                                    "Position Type: Quality control" + Environment.NewLine +
                                    "Core Competency: Persistence" + Environment.NewLine;

            string actualOutput = job3.ToString();
            Assert.AreEqual(expectedOutput, actualOutput, $"Expected:\n{expectedOutput}\nActual:\n{actualOutput}");
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string expectedOutput = Environment.NewLine +
                                    "ID: " + jobWithEmptyFields.Id + Environment.NewLine +
                                    "Name: Data not available" + Environment.NewLine +
                                    "Employer: Data not available" + Environment.NewLine +
                                    "Location: Data not available" + Environment.NewLine +
                                    "Position Type: Data not available" + Environment.NewLine +
                                    "Core Competency: Data not available" + Environment.NewLine;

            string actualOutput = jobWithEmptyFields.ToString();
            Assert.AreEqual(expectedOutput, actualOutput, $"Expected:\n {expectedOutput}\nActual:\n{actualOutput}");
        }

    }
}

