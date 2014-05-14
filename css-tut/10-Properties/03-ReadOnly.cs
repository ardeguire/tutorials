using System;

public class Customer
{
  private int m_id = -1;
  private string m_name = string.Empty;
  
  public Customer(int id, string name)
  {
    m_id = id;
    m_name = name;
  }

  public int ID
  {
    get
    {
      return m_id;
    }
  }

  public string Name
  {
    get
    {
      return m_name;
    }
  }
}

public class ReadOnlyCustomerManager
{
  public static void Main()
  {
    Customer cust = new Customer(1, "Adam De Guire");

    Console.WriteLine(
        "ID: {0}, Name: {1}",
        cust.ID,
        cust.Name);

    // causes a compiler error:
    //cust.Id = 2;
    //cust.Name = "Francis Bacon";

    Console.ReadKey();
  }
}

