using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    class shop
    {
        public string Name { get; set; }
        public int pen { get; set; }
        public int pencil { get; set; }
        public int eraser { get; set; }
        public int ruler { get; set; }
        public int white { get; set; }
        public int money
        {
            get
            {
                return pen * 12 + pencil * 16 + eraser * 10 + ruler * 14 + white * 15;              
            }          
        }
        
    }

    class shop2
    {

        public string sample{ get; set; }
        public int sale { get; set; }
        public int sales { get; set; }
        public int money2
        {
            get { return sale * sales; }
        }
    }

}
