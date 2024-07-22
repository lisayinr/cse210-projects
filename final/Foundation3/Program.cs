using System;

class Program
{
    static void Main(string[] args)
    {
        Address _address1 = new Address("173 Pebble Waters Dr.", "Peachtree City", "GA", "USA");
        Lecture _lecture = new Lecture("Child Education", "The benefits and cons of public education for children", "08-23-2024", "7:00 pm", _address1, "Martha Lewis", 70);

        Address _address2 = new Address("844 Perry Ln.", "Ingersoll", "Ontario", "Canada");
        Reception _reception = new Reception("The Smith's Wedding", "The wedding reception of Nathan and Lola Smith", "07-26-2024", "6:00 pm", _address2, "rsvp-here@yahoo.com");

        Address _address3 = new Address("521 Almond Grove St.", "Stillwater", "OK", "USA");
        OutdoorGathering _outdoorGathering = new OutdoorGathering("Chirstmas Concert", "Various Christmas performances at the plaza open for the community", "12-20-2024", "8:00 pm", _address3, "Light snow");

        // Lecture
        Console.WriteLine($"Standard Details:\n{_lecture.StandardDetails()}\n");
        Console.WriteLine($"Short Description:\n{_lecture.ShortDescription()}\n");
        Console.WriteLine($"Full Details:\n{_lecture.FullDetails()}\n");

        // Reception
        Console.WriteLine($"Standard Details:\n{_reception.StandardDetails()}\n");
        Console.WriteLine($"Short Description:\n{_reception.ShortDescription()}\n");
        Console.WriteLine($"Full Details:\n{_reception.FullDetails()}\n");

        // Outdoor Gathering
        Console.WriteLine($"Standard Details:\n{_outdoorGathering.StandardDetails()}\n");
        Console.WriteLine($"Short Description:\n{_outdoorGathering.ShortDescription()}\n");
        Console.WriteLine($"Full Details:\n{_outdoorGathering.FullDetails()}\n");
    }
}