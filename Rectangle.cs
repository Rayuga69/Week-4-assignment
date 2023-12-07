using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Rectangle
    {
    private float length;
    private float width;
    public Rectangle(float length, float width)
    {
        this.width = width;
        this.length = length;
    }
    public float CalculateArea() {
    return this.width * this.length; }




}
