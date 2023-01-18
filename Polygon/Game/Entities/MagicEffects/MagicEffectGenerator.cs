using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygon.Game.Entities;

namespace Polygon.Entities.MagicEffects
{
    static class MagicEffectGenerator
    {
        public static MagicEffect GenerateMagicEffect()//Воткнуть сюда другую генерацию, чтобы большее число эффектов реже появлялось
        {
            
            int elementCount=1;
            if (World.Level<(int)World.WorldDanger.Dangerous)
            {
                elementCount=World.WorldRandom.Next(1, 2);
            }
            else if(World.Level >= (int)World.WorldDanger.Dangerous && World.Level<(int)World.WorldDanger.Fatal)
            {
                elementCount=World.WorldRandom.Next(10, 31)%10;
            }
            else if(World.Level >=(int)World.WorldDanger.Fatal)
            {
                elementCount=World.WorldRandom.Next(100, 401)%100;
            }

            var elements = Enum.GetValues(typeof(Elements)).OfType<Elements>().ToList();
            List<Elements> chosenElements = new List<Elements>();
            for (int i = 0; i < elementCount; i++)
            {
                chosenElements.Add(elements[World.WorldRandom.Next(0,4)]);
            }
            int strength = 0;
            string adj = GetAdjective(chosenElements.ToArray());
            var resultElements = new List<Element>();
            foreach (var element in chosenElements)
            {
                var generatedElement = ElementGenerator.GenerateElement(element);
                resultElements.Add(generatedElement);
                strength += generatedElement.Value;
            }
            return new MagicEffect(adj,  resultElements);
        }

        static string GetAdjective(Elements[] elements)
        {
            if(elements.Length == 0)
                throw new ArgumentException("elements array should not be empty");
        
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
            return adjective+" ";
        }
    }

}

