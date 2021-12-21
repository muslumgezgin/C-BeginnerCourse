// See https://aka.ms/new-console-template for more information
namespace ClassStarter;

class Program
{
    public static void Main(string[] args)
    {

        Person murat = new Person()
        // here we call the empty constructor
        {
            Age = 12,
            Name = "Murat",
            PartnerName = "Hatun"
        };

        Person muslum = new Person("Muslum", 30, "hatun");
        // here we call the second constructor that takes
        // name age and partnername

        // muslum.Name = "Muslum2";
        //I can not set variable of name after initializer object 

    }


    class Person
    {
        public string? Name { get; init; }

        public int? Age { get; set; }

        public string? PartnerName { get; set; }

        public Person()
        {

        }

        public Person(string name, int age, string partnername)
        {
            Name = name;
            Age = age;
            PartnerName = partnername;

        }



    }

}
