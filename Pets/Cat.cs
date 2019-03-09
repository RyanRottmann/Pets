using System;

namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string type, string name, string owner, double weight) : base("Cat", name, owner, weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public Cat(string name, string owner, double weight) : base("Cat", name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public string Meow(int count)
        {
            string meows = "";
            while (count > 0)
            {
                meows = meows + "meow.";
                count--;
            }
            return meows;
        }
    }
}

