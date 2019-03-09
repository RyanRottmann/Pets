using System;


namespace Pets
{
    public class Dog : Pet
    {
        public Dog(string type, string name, string owner, double weight): base("Dog", name,owner,weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public Dog(string name, string owner, double weight) : base("Dog", name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }
        public string Bark(int count)
        {
            string barks = "";
            while(count > 0)
            {
                barks = barks + "bark!";
                count--;
            }
            return barks;
        }
    }
}
