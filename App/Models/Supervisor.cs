namespace InheritanceDiner.Models
{
    class Supervisor : Server
    {
        public void MakeSchedule()
        {
        }
        public override void Discount()
        {
            System.Console.WriteLine("A 15% Discount!!");
        }
        public Supervisor(string name, string id) : base(name, id)
        {

        }
    }
}