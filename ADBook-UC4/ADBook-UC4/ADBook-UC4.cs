namespace ADBook_UC4
{
    internal class Program
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhNo { get; set; }
            public string Mail { get; set; }

            private static void AddContact()
            {
                Contact contact = new Contact();
            }
            public static List<Contact> Contacts = new List<Contact>();

            static void Main(string[] args)
            {
                Console.WriteLine("*****To edit a existing Contact in the Address Book using their name*****");
                Contact contact = new Contact();

                Console.WriteLine("Enter First Name: ");
                contact.FirstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name: ");
                contact.LastName = Console.ReadLine();

                Console.WriteLine("Enter Address: ");
                contact.Address = Console.ReadLine();

                Console.WriteLine("Enter City: ");
                contact.City = Console.ReadLine();

                Console.WriteLine("Enter State: ");
                contact.State = Console.ReadLine();

                Console.WriteLine("Enter Zip Code: ");
                contact.Zip = Console.ReadLine();

                Console.WriteLine("Enter Phone Number: ");
                contact.PhNo = Console.ReadLine();

                Console.WriteLine("Enter Email Id: ");
                contact.Mail = Console.ReadLine();

                Contacts.Add(contact);

                Console.WriteLine("*****Enter Contact Name to Delete*****");
                string Name = Console.ReadLine();
                if (Name == contact.FirstName)
                {
                    Console.WriteLine("Contact deleted successfully.....!"); 
                }
                else
                {
                    Console.WriteLine("Contact cannot found in Address Book...");
                }
            }
        }
    }
}