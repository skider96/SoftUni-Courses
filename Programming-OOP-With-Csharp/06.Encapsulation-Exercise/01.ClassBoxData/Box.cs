using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length
        {
            get => length;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        double SurfaceArea()
        => 2 * Length * Width + LateralSurfaceArea();

        double LateralSurfaceArea()
        => 2 * Length * Height + 2 * Width * Height;
        
        double Volume()
        => Length * Width * Height;


        public override string ToString()
        => $"Surface Area - {SurfaceArea():f2}\nLateral Surface Area - {LateralSurfaceArea():f2}\nVolume - {Volume():f2}";
    }
}