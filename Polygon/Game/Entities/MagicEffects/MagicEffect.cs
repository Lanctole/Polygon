using System.Collections.Generic;

namespace Polygon.Entities.MagicEffects
{
    public class MagicEffect
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public List<Element> Elements { get; set; }

        public MagicEffect(string name, int strength, List<Element> elements)
        {
            Name = name;
            Strength = strength;
            Elements = new List<Element>();
        }

        public MagicEffect(string name,List<Element> elements)
        {
            this.Name= name;
            this.Elements= elements;
            foreach (var element in elements)
            {
                this.Strength += element.Value;
            }
        }
        
    }

}
