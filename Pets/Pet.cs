using System;


namespace Pets
{
    public class Pet
    {
        public String type;
        public String name;
        public String owner;
        public Double weight;

        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public String getTag()
        {
            String returnString;
            returnString = "If lost call " + owner;
            return returnString;
        }
    }
}
