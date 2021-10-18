using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Square : IShape
    {
        int side;
        double area;
        public   void CalculateArea()
        {
            area = side * side;
        }

        public   void GetDimensions()
        {
            Console.WriteLine("Enter Value for side");
            side = Convert.ToByte(Console.ReadLine());

        }

        public void DispalyArea()
        {
            Console.WriteLine("Area is " + area);
        }

         
    }
}
