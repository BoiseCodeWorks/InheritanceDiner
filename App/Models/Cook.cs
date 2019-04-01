namespace InheritanceDiner.Models
{
    class Cook : Employee
    {
        public void CookFood() { }
        public Cook(string name, string id) : base(name, id)
        {
        }
    }
}