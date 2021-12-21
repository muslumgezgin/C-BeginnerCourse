using System;
namespace ClassStarter.hr
{
    public class Person : BaseEntity, IPerson
    { 
	
        public string? PartnerName { get; set; }


        public Person()
        {

        }

        public Person(string name, int age, string partnername)
        {
            Name = name;
            Age = age;
            PartnerName = partnername;
            DateOfBirth = DateTime.Now;

        }

        public static int multipleNumber(int a, int b)
        {
            return a * b;
        }

        public void Setsomething(int x)
        {
            throw new NotImplementedException();
        }

        public int setNumbeer()
        {
            throw new NotImplementedException();
        }

    }
}

