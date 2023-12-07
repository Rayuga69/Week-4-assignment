using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class Shape
    {
    public virtual float CalculateArea(float radius)
    {
        return 0f;
    }
    }

    class Circle : Shape
{
    public override float CalculateArea(float radius)
    {
        return (22 / 7) * (radius * radius);
        
    }
}