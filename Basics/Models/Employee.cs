namespace Basics.Models
{
  public class Employee
  {
    public int Id { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String FullName => $"{FirstName} {LastName.ToUpper()}";
    public int Age { get; set; }
        
  }

}