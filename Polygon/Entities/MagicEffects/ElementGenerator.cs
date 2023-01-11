using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Entities.MagicEffects
{
    static class ElementGenerator
    {
        public static Element GenerateElement(Elements element)
        {
            var resultElement = new Element(element);
            var random = new Random();
            resultElement.Value= World.Level*World.PowerScaling+random.Next(1, World.PowerScaling*2);
            return resultElement;
        }
    }
}
