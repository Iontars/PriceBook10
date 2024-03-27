namespace Chapter_1
{
    internal class Program
    {
        protected Person person = new(1000,null);
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine();
            Console.WriteLine(program.person.Name);
            program.person.Name = "Den";
            program.OtherMethot();
        }

        private void OtherMethot()
        {
            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        public int Money { get; set; }
        public string Name { get; set; }
        public Person(int money, string? name)
        {
            Money = money;
            Name = name ?? "Default";
        }
    }
}