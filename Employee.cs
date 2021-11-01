using System;
class Employee {

  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

  public Employee ()
  {
    firstname = "unknown";
    lastname = "unknown";
    id = "unknown";
    age = 0;
    employmentstatus = "active";
  }

  public Employee (string first, string last, string employeeid, int employeeage)
  {
    firstname = first;
    lastname = last;
    id = employeeid;
    age = employeeage;
    employmentstatus = "active";
  }

  public void Intro()
  {
    Console.WriteLine("First Name: "+firstname);
    Console.WriteLine("Last Name: "+lastname);
    Console.WriteLine("ID: "+id);
    Console.WriteLine("Age: "+age);
    Console.WriteLine("Employment Status: "+employmentstatus);
  }



}