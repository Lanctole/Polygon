using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygon.Game.Entities;

namespace Polygon.Entities.MagicEffects
{
    static class ElementGenerator
    {
        public static Element GenerateElement(Elements element)
        {
            var resultElement = new Element(element)
            {
                Value = NumeralCharacteristicsGenerator.GenerateElementValue()
            };
            return resultElement;
        }
    }
}
