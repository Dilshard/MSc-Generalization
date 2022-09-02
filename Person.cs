using System;
namespace Generalization
{
	public abstract class Person
	{
		protected String name;
		private int age;
		private String address;

		public Person(String name, int age, String address)
        {
			this.name = name;
			this.age = age;
			this.address = address;
        }

		public String getName()
        {
			return this.name;
        }
		public void setName(String newName)
        {
			this.name = newName;
        }

		public int getAge()
        {
			return age;
        }

		public String getAddress()
        {
			return address;
        }

		//Over ride version 01 #no definition
		public abstract void getJobDetails();

		//Over ride version 02 #has definition
		public virtual void getLocation()
        {
			Console.WriteLine("Latitude" + "Longtitude");
		}

		public virtual void display()
        {
            Console.WriteLine("Name : "+getName());
            Console.WriteLine("Age : "+getAge());
            Console.WriteLine("Address : "+getAddress());
		}

	}
}

