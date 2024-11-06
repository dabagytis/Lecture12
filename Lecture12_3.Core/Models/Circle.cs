using Lecture12_3.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12_3.Core.Models
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            double circleArea = Math.PI * Math.Pow(Radius, 2);
            return circleArea;
        }
    }
}
