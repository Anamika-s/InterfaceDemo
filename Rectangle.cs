using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Rectangle : IShape
    {
        int length;
        int width;
        double area;
        public   void GetDimensions()
        {
            Console.WriteLine("Enter Value for Length");
            length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Value for Width");
            width = Convert.ToByte(Console.ReadLine());

        }
        public   void CalculateArea()
        {
            area = length * width;
        }
        public void DispalyArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
