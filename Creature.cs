using System;
namespace Module2HM3
{
    public class Creature 
    {
        public string Name1 { get; internal set; }

        public virtual void Run()
        {
            Console.WriteLine("Run, creature, run!");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Goodnight, little creature");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Is it lunch time yet?");
        }

        public virtual void Purr()
        {
            Console.WriteLine("Purrrrrrr...");
        }
        
    }
   

}

