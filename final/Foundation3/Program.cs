using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Main 123", "Provo", "Utah", "USA");
        Address address2 = new Address("Nacional 123", "Monterrey", "Nuevo Leon", "Mexico");
        Address address3 = new Address("Pueblo 123", "Choix", "Sinaloa", "Mexico");

        Lecture lecture = new Lecture("Little Price", "Child's Lecture", "Dec 23", "10 AM", address1, "Exupery", 20);
        Reception reception = new Reception("Wedding", "Lopez Wedding", "Sep 17", "7 PM", address2, "Confirmed 100 people");
        Gathering gathering = new Gathering("Party", "Soto's party", "Jun 10", "4 PM", address3, "Sunny");
        
        Console.WriteLine("Event 1 - Standard Details");
        lecture.StandardDetails();
        Console.WriteLine();
        Console.WriteLine("Event 1 - Full Details");
        lecture.FullLectureDetails();
        Console.WriteLine();
        Console.WriteLine("Event 1 - Short Description");
        lecture.ShortDescription();
        Console.WriteLine();

        Console.WriteLine("Event 1 - Standard Details");
        reception.StandardDetails();
        Console.WriteLine();
        Console.WriteLine("Event 1 - Full Details");
        reception.FullReceptionDetails();
        Console.WriteLine();
        Console.WriteLine("Event 1 - Short Description");
        reception.ShortDescription();
        Console.WriteLine();

        Console.WriteLine("Event 1 - Standard Details");
        gathering.StandardDetails();
        Console.WriteLine();
        Console.WriteLine("Event 1 - Full Details");
        gathering.FullGatheringDetails();
        Console.WriteLine();
        Console.WriteLine("Event 1 - Short Description");
        gathering.ShortDescription();
    }
}