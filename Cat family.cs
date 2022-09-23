using System;
namespace Module2HM3
{
    public class Cat_family : Mamal
    {
        
        public string Breed { get; set; }
        public string Colour { get; set; }
        public string TypeOfFur { get; set }
        private string _name;
        public string Name
        {
            get
            {
                return "Tosha";
            }
            set { _name = value; }
        }
        public Cat_family(string name)
        {
            Name = name;
        }
    }
}

