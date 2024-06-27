using System;
using System.Text;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.

            public Job()
            {
                Id = nextId;
                nextId++;
            }

            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }

            // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

            public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine);
            sb.Append("ID: ").Append(Id).Append(Environment.NewLine);
            sb.Append("Name: ").Append(string.IsNullOrEmpty(Name) ? "Data not available" : Name).Append(Environment.NewLine);
            sb.Append("Employer: ").Append(string.IsNullOrEmpty(EmployerName?.Value) ? "Data not available" : EmployerName.Value).Append(Environment.NewLine);
            sb.Append("Location: ").Append(string.IsNullOrEmpty(EmployerLocation?.Value) ? "Data not available" : EmployerLocation.Value).Append(Environment.NewLine);
            sb.Append("Position Type: ").Append(string.IsNullOrEmpty(JobType?.Value) ? "Data not available" : JobType.Value).Append(Environment.NewLine);
            sb.Append("Core Competency: ").Append(string.IsNullOrEmpty(JobCoreCompetency?.Value) ? "Data not available" : JobCoreCompetency.Value).Append(Environment.NewLine);
            //sb.Append(Environment.NewLine);

            return sb.ToString();
        }







    }
}

