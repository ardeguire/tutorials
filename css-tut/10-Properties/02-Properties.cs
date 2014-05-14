using System;

public class Customer
{
  private int m_id = -1;

  public int ID
  {
    get
    {
      return m_id;
    }
    set
    {
      m_id = value;
    }
  }

  private string m_name = string.Empty;

  public string Name
  {
    get
    {
      return m_name;
    }
    set
    {
      m_name = value;
    }
  }
}

public class CustomerManagerWithProperties
{
  public static void Main()
  {
    Customer cust = new Customer();

    cust.ID = 1;
    cust.Name = "Adam De Guire";

    Console.WriteLine(
        "ID: [0], Name: {1}",
        cust.ID,
        cust.Name);

    Console.ReadKey();
  }
}

