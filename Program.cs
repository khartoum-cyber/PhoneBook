using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from PhoneBook app!");

            Console.WriteLine("1 - Add contact.");
            Console.WriteLine("2 - Display contact by number.");
            Console.WriteLine("3 - Display all contacts.");
            Console.WriteLine("4 - Search contacts.");
            Console.WriteLine("0 - Exit app.");


            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();

                        Contact newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Insert number to be found");
                        var searchNumber = Console.ReadLine();

                        phoneBook.DisplayNumber(searchNumber);
                        break;

                    case "3":
                        Console.WriteLine("Displaying all contacts");
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":
                        Console.WriteLine("Enter a phrase to search by");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
                userInput = Console.ReadLine();

            }
        }
    }
}
