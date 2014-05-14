using System;

public class Customer
{
  private int m_id = -1;

  public int GetID()
  {
    return m_id;
  }

  public void SetID(int id)
  {
    m_id = id;
  }

  private string m_name = string.Empty;

  public string GetName()
  {
    return m_name;
  }

  public void SetName(string name)
  {
    m_name = name;
  }
}

public class CustomerManagerWithAccessorMethods
{
  public static void Main()
  {
    Customer cust = new Customer();

    cust.SetID(1);
    cust.SetName("Adam De Guire");

    Console.WriteLine(
        "ID: [0], Name: {1}",
        cust.GetID(),
        cust.GetName());

    Console.ReadKey();
  }
}

