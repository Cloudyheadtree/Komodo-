namespace KomoGreeting.ConsoleApp
{
    public class ProgramUI
    {
        //greeting repo
        private KomoGreetingRepo _greetingsRepo = new KomoGreetingRepo();
        public void Run()
        {
            CustomerGreetings();
            EmailOptions();
        }
        public void EmailOptions()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nWhat would you like to do?\n" +
                "Option 1: Show Customers\n" +
                "Opton 2: Would You Like To Add a Customer?\n" +
                "Option 3: Would You Like To Update Customers?\n" +
                "Options 4: Bye-Bye");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                    ShowCustomers();
                    break;
                    case "2":
                    AddCustomer();
                    case "3":
                    UpdateCustomer();
                    case "4":
                    isRunning = false;
                    break;
                    default:
                    break;


                }
                Console.WriteLine("\nPress Any Key To Continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void ShowCustomers()
        {
            List<Greet> komoGreetings = _greetingsRepo.CustomerList();
            komoGreetings.Sort(delegate (Greet x, Greet y)
            {
                return x.LastName.CompareTo(y.LastName);
            });
            List<string> headings = new List<string> {"First", "Last", "Status", "Email"};
            Console.Clear();
            foreach (Greet greet in komoGreetings)
            {
                Console.WriteLine($"{greet.First} {greet.Last} {greet.Status} {greet.Email}");

            }

        }
        private void AddCustomer()
        {
            Console.WriteLine("Customer First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Customer Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"\nStatus of {firstName} {lastName}\n" +
            "1. Current Customer\n" +
            "2. Previous Customer\n" +
            "3. Potential Customer\n" +
            "Select Option");
            string optionSelect = Console.ReadLine();
            CustomerStatus newStatus = CustomerStatus.Potential;
            
            switch (optionSelect)
            {
                case "1":
                customerType = CustomerStatus.Current;
                break;
                case "2":
                customerType = CustomerStatus.Past;
                break;
                case "3":
                customerType = CustomerStatus.Potential;
                break;
                default:
                break;


            }
           
        }
        private void UpdateCustomer()
        {
            Console.WriteLine("Update Customer Status Here");
        }
        private void CustomerGreetings()
        {
            Greet customer1 = new Greet("Elon", "Musk", CustomerStatus.Current);
            Greet customer2 = new Greet("James", "Cameron", CustomerStatus.Previous);
            Greet customer3 = new Greet("Johnny", "Depp", CustomerStatus.Potential);
            Greet customer4 = new Greet("Amber", "Heard", CustomerStatus.Previous);

            _greetingsRepo.AddGreeting(customer1);
            _greetingsRepo.AddGreeting(customer2);
            _greetingsRepo.AddGreeting(customer3);
            _greetingsRepo.AddGreeting(customer4);
        }

       
    }
}