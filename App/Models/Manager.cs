namespace InheritanceDiner.Models
{
    class Manager : Supervisor
    {
        int PinCode { get; set; }
        public override void Discount()
        {
            System.Console.WriteLine("A 50% Discount!!");
        }
        public void TerminateEmployee()
        {

        }
        public void HireEmployee()
        {

        }
        public void Delegate()
        {
            System.Console.WriteLine("DO MY WORK!!!");
        }
        public Manager(string name, string id, int pin) : base(name, id)
        {
            PinCode = pin;
        }
    }
}