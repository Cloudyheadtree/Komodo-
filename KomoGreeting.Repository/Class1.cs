namespace KomoGreeting.Repository;
public class KomoGreetingRepo
{
private List<Greet> _greetingsList = new List<Greet>();

public void AddGreeting(Greet greet)
{
    _greetingsList.Add(greet);
}
public List<Greet> GetGreetsList()
{
    return _greetingsList;
}
public bool UpdateCustomerGreeting(string firstName, string lastName, Greet newGreeting)
{
    Greet oldGreet = GetCustomerName(firstName, lastName);
    if (oldGreet != null)
    {
        oldGreet.FirstName = newGreet.FirstName;
        oldGreet.LastName = newGreet.LastName;
        oldGreet.CustomerStatus = newGreet.CustomerStatus;
        return true;
    }
    else
    {
        return false;
    }
    
}
public bool deleteCustomer(string firstName, string lastName);
{
    Greet deleteCustomer = GetCustomerByFullName(firstName, lastName);
    if (deleteCustomer == null)
    {
        return false;
    }
    



}


}
