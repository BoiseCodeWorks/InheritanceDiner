namespace InheritanceDiner.Models
{
    class Server : Employee
    {
        public void CreateTicket() { }
        public Server(string name, string id) : base(name, id)
        { }
    }
}