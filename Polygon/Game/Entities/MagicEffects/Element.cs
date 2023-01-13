
namespace Polygon.Entities.MagicEffects
{
    public class Element
    {
        public Elements Type { get; set; }
        public int Value { get; set; }
        
        public Element(Elements type)
        {
            Type = type;
        }
        
    }
}
