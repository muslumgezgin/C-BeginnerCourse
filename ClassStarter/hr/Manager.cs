using System;
namespace ClassStarter.hr
{
	public class Manager : BaseEntity
	{
        public string Role { get; set; }
        public Manager()
		{
			Name = "murat";
			HouseAddress = "sneokenveen";
			DateOfBirth = DateTime.Now;
		}
	}
}

