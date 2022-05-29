namespace KomoGreeting.Repository
{
    public class Greet
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string CustomerStatus {get; set;}
        public Greet () {}
        public Greet(string firstName, string lastName, string customerStatus)
        {
            FirstName = firstName;
            LastName = LastName;
            CustomerStatus = customerStatus;
            switch (customerStatus)
            {
                case CustomerStatus.Current:
                Console.WriteLine("Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
                break;
                case CustomerStatus.Previous:
                Console.WriteLine("Was it something we said?");
                break;
                case CustomerStatus.Potential:
                Console.WriteLine("We currently have the lowest rates for monster mayhem insurance!");
                break;
            }
        }

    }
}