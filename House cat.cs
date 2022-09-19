using System;
namespace Module2HM3
{
    public sealed class House_cat : Cat_family, IRun, ISleep, IEat, IPurr
    {
        public override void Run()
        {
            base.Run();
        }
        public override void Sleep()
        {
            base.Sleep();
        }
        public void Eat()
        {
            base.Eat();
        }
        public void Purr()
        {
            base.Purr();
        }

        public House_cat(string name) : base{ name}
    }
    
}

