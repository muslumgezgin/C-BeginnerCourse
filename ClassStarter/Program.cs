// See https://aka.ms/new-console-template for more information
using ClassStarter.hr;

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

        // we use static method that does not neeeded to create an object
        var newNumber = Person.multipleNumber(3, 2);

        Console.WriteLine(newNumber);

        Person muslum = new Person("Muslum", 30, "hatun");
        // here we call the second constructor that takes
        // name age and partnername

        // muslum.Name = "Muslum2";
        //I can not set variable of name after initializer object 

    }


}
