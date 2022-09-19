using System;
namespace Module2HM3
{
    public class Doggy : Creature, IRun, ISleep, IEat, IPurr
    {
        public override void Run()
        {
            base.Run();
        }
        public override void Sleep()
        {
            base.Sleep();
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void Purr()
        {
            Console.WriteLine("Dogs don't purr, silly");
        }
        private string _name1;
        public string Name1
        {
            get
            {
                return "Bieber";
            }
            set { _name1 = value; }
        }
        public Doggy(string name1)
        {
            Name1 = name1;
        }

    }
}

