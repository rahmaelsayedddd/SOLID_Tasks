using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Task03
    {
    }
    public abstract class Shape1D
    {
        public double Dim1 { set; get; }

        public Shape1D(double _d1)
        {
            Dim1 = _d1;
        }
    }
    public abstract class Shape2D
    {
        public double Dim1 { set; get; }
        public double Dim2 { set; get; }

        public Shape2D(double _d1, double _d2)
        {
            Dim1 = _d1;
            Dim2 = _d2;
        }
    }
    public class Rect : Shape2D
    {
        public Rect(double _d1, double _d2) : base(_d1, _d2)
        {}
    }
    public class Squar : Shape1D
    {
        public Squar(double _side) : base(_side)
        { }
    }
}
