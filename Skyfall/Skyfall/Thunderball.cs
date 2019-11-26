using System;

namespace Thunderball
{
    public class Civ
    {
        string civ_name;
        string civ_desc;
        string civ_uu;
        string civ_weak = "Goths";

        //constructors
        public Civ()
        {
            Console.WriteLine("thunderball");
        }

        public Civ(string name)
        {
            civ_name = name;
        }
        public Civ(string name, string description, string unique_unit)
        {
            civ_name = name;
            civ_desc = description;
            civ_uu = unique_unit;
     
	    }

        //methods
        public void Weakness()
        {
            Console.WriteLine(civ_name + " are weak against: " + civ_weak);
        }

        //getters
        public string getName()
        {
            return civ_name;
        }

        public string getDesc()
        {
            return civ_desc;
        }

        public string getUU()
        {
            return civ_uu;
        }

        //setters
        public void setName(string name)
        {
            civ_name = name;
        }

        public void setDesc(string description)
        {
            civ_desc = description;
        }

        public void setUU(string uu)
        {
            civ_uu = uu;
        }

        
    }
}
