using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber9
{
    class Circle
    {
        private double radius;// step 1

           

        public double Radius// step2 
        {
            set { radius = value; }
            get { return radius; }
        }
        public  double GetCircumference()
        {
            double pi = Math.PI;
            double circumference = 2 * pi * radius;
            return circumference;
        }


        public double Getarea()
        {
            double pi = Math.PI;
            double area = pi * radius * radius;
            return area;
        }

        public void GetRadius()
        {
            double solutionForRadius;

            Console.WriteLine("Please enter a radius");
            solutionForRadius = double.Parse(Console.ReadLine());

            double pi = Math.PI;
            double getCircumference = 2 * pi * solutionForRadius;
            double getArea = pi * solutionForRadius * solutionForRadius;
            Console.WriteLine("The Circumference of your circle is: " + getCircumference);
            Console.WriteLine("The area is " + getArea);

        }

    
