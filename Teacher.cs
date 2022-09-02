using System;
namespace Generalization
{
	public class Teacher:Person
	{
		private String schoolName;
		private int experience;
		private double salary;
		private String subject;

		public Teacher(String schoolName, int experience, String name, int age, String address):base(name,age,address)
		{
			this.schoolName = schoolName;
			this.experience = experience;
		}

		public override void getJobDetails()
		{
			Console.WriteLine("Teacher");
		}



		public override void display()
        {
            Console.WriteLine("Details about teacher");
        }
	}
}

