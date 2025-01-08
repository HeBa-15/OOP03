using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Rectangle
    {

        public int Width { get; set; }
        public int Height { get; set; }
    
        public Rectangle() 
        { 
            Width = 0; 
            Height = 0;
        } 
     
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        } 
          
        public Rectangle(int Val) 
        { 
            Width = Val;
            Height = Val;
        }
    }
}
