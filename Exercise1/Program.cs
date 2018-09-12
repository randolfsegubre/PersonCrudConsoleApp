using Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise1
{
    public class Program
    {
        List<Person> personList = new List<Person>();
        Person _person;
        static void Main(string[] args)
        {
            Program p = new Program();
            try
            {
                p.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("1 -- Restart");
                Console.WriteLine("2 -- Exit");
                int input = Int32.Parse(Console.ReadLine());
                if (input == 1) System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                Environment.Exit(0);
                Console.ReadLine();
            }
            
        }
      

        #region Program Execution
        private void Execute()
        {
            int option = 0;

            while (true)
            {
                Console.WriteLine("Select Option");
                Console.WriteLine("1 --- Add");
                Console.WriteLine("2 --- Search");
                option = int.Parse(Console.ReadLine().ToString());

                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Search();
                        break;
                    default:
                        break;
                }

            }
        }
        #endregion

        #region Adding Email
        private void GenerateEmail()
        {
            string choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1 -- Suggested : {0}@yahoo.com", _person.ScreenName1);
                Console.WriteLine("2 -- Suggested : {0}@yahoo.com", _person.ScreenName2);
                Console.WriteLine("3 -- Suggested : {0}@yahoo.com", _person.ScreenName3);
                Console.Write("Choose number for Email : ");
                 choice = (string)Console.ReadLine();

                if (!String.IsNullOrEmpty(choice))
                {
                    switch (choice)
                    {
                        case "1":
                            _person.Email = _person.ScreenName1;
                            break;
                        case "2":
                            _person.Email = _person.ScreenName2;
                            break;
                        case "3":
                            _person.Email = _person.ScreenName3;
                            break;
                        default:
                            _person.Email = choice;
                            break;
                    }
                }
            } while (String.IsNullOrEmpty(choice));

        }
        #endregion

        #region Adding
        private void Add()
        {
            _person = new Person();
            Console.WriteLine("This represent an example of crud operation, a list of people");
            Console.WriteLine();
            Console.WriteLine("Enter data as follows:");
            Console.WriteLine();
            Console.Write("First Name : ");
            _person.FirstName = (string)Console.ReadLine();

            Console.Write("Last Name : ");
            _person.LastName = (string)Console.ReadLine().ToString();
            
            Console.Write("Date Of Birth : ");
            _person.DateOfBirth = DateTime.Parse(Console.ReadLine().ToString());

            GenerateEmail();
            
            _person.Id = personList.Count + 1;

            personList.Add(_person);

        }
        #endregion

        #region Searching
        private void Search()
        {
            Console.Write("Search : ");
            string search = Console.ReadLine().ToString();

            var results = personList.Where(x => x.FirstName.ToLower().Contains(search.ToLower()) || x.LastName.ToLower().Contains(search.ToLower()));

            Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5}", "ID", "First Name", "Last Name", "Email", "Date of Birth", "Sun Sign");
            if (search != "")
            {
                foreach (var item in results)
                {
                    Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5}", item.Id, item.FirstName, item.LastName, item.Email, item.DateOfBirth, new SunSign().ZodiacSign);
                }
            }
            else
            {
                foreach (var item in personList)
                {
                    Console.WriteLine("{0} || {1} || {2} || {3} || {4} || {5}", item.Id, item.FirstName, item.LastName, item.Email, item.DateOfBirth, new SunSign().ZodiacSign);
                }
            }
            Console.ReadLine();
        }
        #endregion

    }
}
