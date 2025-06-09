using System.Net.Sockets;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public bool CustomerLocation()
    {
        return _address.IsInUSA();
    }

    public Address GetAddress()
    {
        return _address;
    }
}

