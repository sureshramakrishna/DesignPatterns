using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.StructuralDesignPattern.Adapter
{
    interface IShape
    {
        void Draw(int x, int y, int w, int h);
    }
    class Adaptee
    {
        public void Draw(int x1, int y1, int x2, int y2)
        {

        }
    }
    class Adapter : IShape
    {
        private Adaptee _adaptee;
        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public void Draw(int x, int y, int w, int h)
        {
            var x2 = x + w;
            var y2 = y + h;
            _adaptee.Draw(x, y, x2, y2);
        }
    }

    class AdapterDesignPattern
    {
        public void Demo()
        {
            IShape s = new Adapter();
            s.Draw(10, 10, 5, 6);
        }
    }
}
