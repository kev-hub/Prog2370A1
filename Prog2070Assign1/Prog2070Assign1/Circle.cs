/* 
 Program Name : Prog2070Assign1
 Class Purpose : Circle Object and Methods
 Date : Feb 11,2020
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Prog2070Assign1
{
    public class Circle
    {
        
        public int radius;

        public Circle()
        {
            radius = 1;
        }
        /// <summary>
        /// Gets the Radis of the circle
        /// </summary>
        /// <returns></returns>
        public int GetRadius()
        {
            int currentRadius;
            currentRadius = radius;
            return currentRadius;
        }
        /// <summary>
        /// Sets the radius the user Selected
        /// </summary>
        /// <param name="radius"></param>
       public void SetRadius(int radius)
        {
            int userRadius;
            userRadius = int.Parse(Console.ReadLine());
            radius = userRadius;
        }
        /// <summary>
        /// gets the circumfrence of the radius
        /// </summary>
        /// <returns></returns>
       public double GetCircumference()
        {
            double Circumfrence;
            Circumfrence = (GetRadius() * 2) * Math.PI;
            return Circumfrence;
        }
        /// <summary>
        /// gets the area
        /// </summary>
        /// <returns></returns>
       public double GetArea()
        {
            double area;
            area = (GetRadius() ^ 2) * Math.PI;
            area = Math.Round(area);
            return area;
        }
    }
}
