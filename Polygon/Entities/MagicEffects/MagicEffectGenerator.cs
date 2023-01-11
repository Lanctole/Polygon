using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Entities.MagicEffects
{
    static class MagicEffectGenerator
    {
        public static MagicEffect GenerateMagicEffect()//Воткнуть сюда другую генерацию, чтобы большее число эффектов реже появлялось
        {
            var random = new Random();
            int elementCount=1;
            if (World.Level<50)
            {
                elementCount=random.Next(1, 2);
            }
            else if(World.Level >= 50 && World.Level<75)
            {
                elementCount=random.Next(1, 3);
            }
            else if(World.Level >= 75)
            {
                elementCount=random.Next(1, 4);
            }

            var elements = Enum.GetValues(typeof(Elements)).OfType<Elements>().ToList();
            var chosenElements = elements.OrderBy(x => random.Next()).Take(elementCount);
            int strength = 0;
            string adj = GetAdjective(chosenElements.ToArray());
            var resultElements = new List<Element>();
            foreach (var element in chosenElements)
            {
                resultElements.Add(ElementGenerator.GenerateElement(element));
                strength += (int)element;
                
            }
            return new MagicEffect(adj + "Blast",  resultElements);
        }

        static string GetAdjective(Elements[] elements)
        {
            if(elements.Length == 0)
                throw new ArgumentException("elements array should not be empty.");
        
            var adjective = "";
            
            var elementAdjectives = new Dictionary<Elements, string>
            {
                { Elements.Fire, "fiery" },
                { Elements.Ice, "frosty" },
                { Elements.Earth, "earthy" },
                { Elements.Water, "watery" }
            };
            
            for(int i = 0; i < elements.Length; i++)
            {
                if (i > 0) adjective += "-";
                adjective += elementAdjectives[elements[i]];
                
            }
            return adjective;
        }
    }

}

