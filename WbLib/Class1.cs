using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WbLib
{
    public class Calulator
    {
        public int Square(int no) { return no * no; }
        public int Cube(int no) { return this.Square(no) * no; }
    }
}
