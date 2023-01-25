// See https://aka.ms/new-console-template for more information
using Lab1_AI;
using System.Security.Cryptography.X509Certificates;

class MainClass
{
    public static void Main(string[] args)
    {
        Person p1 = new Person(1, "Ian", "Brooks", "White", 30, true);
        Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        //info display part
        p2.DisplayPersonInfo();
        Console.WriteLine(p3.ToString());
        p1.ChangeFavoriteColour();
        p1.DisplayPersonInfo();
        Console.WriteLine($"{p4.FirstName} {p4.LastName}'s Age in 10 years is: {p4.GetAgeInTenYears()}");

        //relation part
        Relation sister = new Relation("Sisterhood");
        sister.ShowRelationShip(p2, p4);
        Relation bro = new Relation("Brotherhood");
        bro.ShowRelationShip(p1, p3);

        //list part average calculate
        List<Person> Plist = new List<Person> { p1, p2, p3, p4 };
        double averageAge = Plist.Average(p => p.Age);
        Console.WriteLine("Average age is: " + averageAge);

        //youngest & oldest 
        var youngestPerson = Plist.OrderBy(p => p.Age).First();  //order ages 
        var oldestPerson = Plist.OrderBy(p => p.Age).Last();
        Console.WriteLine("The youngest person is: " + youngestPerson.FirstName);
        Console.WriteLine("The oldest person is: " + oldestPerson.FirstName);
        // find firstname with M
        var peopleWithM = Plist.Where(p => p.FirstName.StartsWith("M"));

        foreach (var y in peopleWithM)
        {
            Console.WriteLine(y.ToString());
        }


        //find whose favorite colour is blue
        var peopleLikeBlue = Plist.Where(p => p.FavoriteColour == "Blue");

        foreach (var x in peopleLikeBlue)
        {
            Console.WriteLine(x.ToString());
        }
    }
}
    
        
   

   


   

