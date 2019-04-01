namespace InheritanceDiner.Models
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public void ClockIn()
        {

        }
        public virtual void Discount()
        {
            System.Console.WriteLine("A 5% Discount!!");
        }
        public void ClockOut()
        {

        }
        public Employee(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}