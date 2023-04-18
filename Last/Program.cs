using System;
using System.Collections.Generic;
using System.Linq;

namespace Last
{
        class Program
        {
            static void Main(string[] args)
            {
            ////Task 1

            //List<Contact> contacts = new List<Contact>();

            //while (true)
            //{
            //    Console.WriteLine("1. Add contact");
            //    Console.WriteLine("2. Remove contact");
            //    Console.WriteLine("3. Display contacts");
            //    Console.WriteLine("4. Exit");

            //    Console.Write("Enter your choice: ");
            //    string input = Console.ReadLine();

            //    switch (input)
            //    {
            //        case "1":
            //            Console.Write("Enter name: ");
            //            string name = Console.ReadLine();

            //            Console.Write("Enter phone number: ");
            //            string phoneNumber = Console.ReadLine();

            //            Contact newContact = new Contact();
            //            newContact.Name = name;
            //            newContact.PhoneNumber = phoneNumber;
            //            contacts.Add(newContact);

            //            Console.WriteLine("Contact added");
            //            break;

            //        case "2":
            //            Console.Write("Enter name of contact to remove: ");
            //            string nameToRemove = Console.ReadLine();

            //            Contact contactToRemove = contacts.FirstOrDefault(c => c.Name == nameToRemove);
            //            if (contactToRemove != null)
            //            {
            //                contacts.Remove(contactToRemove);
            //                Console.WriteLine("Contact removed.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact not found.");
            //            }
            //            break;

            //        case "3":
            //            Console.WriteLine("Contacts:");
            //            foreach (Contact contact in contacts)
            //            {
            //                Console.WriteLine("Name: " + contact.Name);
            //                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
            //            }
            //            break;

            //        case "4":
            //            Console.WriteLine("Goodbye!");
            //            return;

            //        default:
            //            Console.WriteLine("Invalid choice.");
            //            break;
            //    }

            //    Console.WriteLine();
            //}




            ////Task 2
            //Console.Write("Enter text:");
            //Console.ForegroundColor=ConsoleColor.Red;
            //string text = Console.ReadLine();
            //Console.ResetColor();
            //string[] words = text.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            //Dictionary<string, int> count = new Dictionary<string, int>();

            //foreach (string item in words)
            //{
            //    if (count.ContainsKey(item))
            //    {
            //        count[item]++;
            //    }
            //    else
            //    {
            //        count[item] = 1;
            //    }
            //    Console.WriteLine(count[item]);
            //}
           

            }
        }

        public class Contact
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
        }
}
