using System;
namespace Generalization
{
	public class Student:Person,iLocation,iCountable
	{
		private double fee;
		private String studentNo;

		//add base for parameter that we have in parent class parameters
		public Student(String name, int age, String address, String studentNo, double fee):base(name,age,address) 
		{
			this.fee = fee;
			this.studentNo = studentNo;
		}

		public void setFee(double fee)
        {
			this.fee = fee;
        }

		public double getFee()
        {
			return fee;
        }

		public void setStudentNo(String studentNo)
        {
			this.studentNo = studentNo;
        }

		public String getStudentNo()
        {
			return studentNo;
        }

		public override void getJobDetails()
        {
            Console.WriteLine("Student");
        }

		public override void getLocation()
		{
			base.getLocation();
			Console.WriteLine("IIT Ramacrishna road, Colombo 06");
		}

		public double getLatitude()
        {
			double latitude = 1.233;
			return latitude;
        }
		public void setLatitude(double latitudeValue)
        {
            Console.WriteLine("Latitude : "+latitudeValue);
        }

		public double getLongtitude()
        {
			double longtitude = 2.233;
			return longtitude;
		}
		public void setLongtitude(double longtitudeValue)
        {
            Console.WriteLine("Longtitude : " + longtitudeValue);

		}
		public void count()
        {
            Console.WriteLine("Count : 10");
        }

        public override string ToString()
        {
			String value = "Sample";
			return value;
        }

		public override void display()
        {
            Console.WriteLine(getFee());
            Console.WriteLine(getStudentNo());
        }
    }
}

