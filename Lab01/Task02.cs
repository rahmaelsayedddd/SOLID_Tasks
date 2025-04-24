using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Task02
    { }

    public interface IShape
    {
        double calcArea();
    }
    public interface I3DShape
    {
        double calcVolume();
    }

    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Wight { get; set; }

        public double calcArea()
        {
            return Height * Wight;
        }
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double calcArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Square : IShape
    {
        public double Side { get; set; }

        public double calcArea()
        {
            return Side * Side;
        }
    }

    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double calcArea()
        {
            return 0.5 * Base * Height;
        }
    }
    public class Cube : IShape,I3DShape
    {
        public double Side { get; set; }

        public double calcArea()
        {
            return 6 * Math.Pow(Side, 2);
        }

        public double calcVolume()
        {
            return Math.Pow(Side, 3);
        }
    }
    public class AreaCalculator
    {
        public double TotalArea(List<IShape> shapes)
        {
            double area = 0;

            foreach (var obj in shapes)
            {
                area += obj.calcArea();
            }
            return area;
        }
    }
    public class VolumeCalculator
    {
        public double TotalArea(List<I3DShape> shapes)
        {
            double volume = 0;

            foreach (var obj in shapes)
            {
                volume += obj.calcVolume();
            }
            return volume;
        }
    }
}
   