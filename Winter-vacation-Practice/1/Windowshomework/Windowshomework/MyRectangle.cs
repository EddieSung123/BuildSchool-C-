using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windowshomework
{
    class MyRectangle
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public int Area  //要是屬性
        {
            get
            {
                return Width * Height;
            }
        }
    }
}
