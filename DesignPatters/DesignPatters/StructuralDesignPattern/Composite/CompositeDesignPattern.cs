using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.StructuralDesignPattern.Composite
{
    /** "Component" */
    interface IGraphic
    {
        //Prints the graphic.
        public void Print();
    }

    /** "Composite" */
    class CompositeGraphic : IGraphic
    {
        //Collection of child graphics.
        private readonly List<IGraphic> _childGraphics = new List<IGraphic>();

        //Adds the graphic to the composition.
        public void Add(IGraphic graphic)
        {
            _childGraphics.Add(graphic);
        }

        // This is only shallowCopy
        public void Add(List<IGraphic> compositeGraphic)
        {
            _childGraphics.AddRange(compositeGraphic);
        }

        //Prints the graphic.
        public void Print()
        {
            foreach (IGraphic graphic in _childGraphics)
            {
                graphic.Print();  //Delegation
            }
        }
    }

    /** "Leaf" */
    class Ellipse : IGraphic
    {
        //Prints the graphic.
        public void Print()
        {
            Console.WriteLine("Ellipse");
        }
    }

    /** Client */
    class CompositeDesignPattern
    {
        public void Demo()
        {
            //Initialize four ellipses
            Ellipse ellipse1 = new Ellipse();
            Ellipse ellipse2 = new Ellipse();
            Ellipse ellipse3 = new Ellipse();
            Ellipse ellipse4 = new Ellipse();

            //Creates two composites containing the ellipses
            CompositeGraphic compositeGraphic2 = new CompositeGraphic();
            compositeGraphic2.Add(ellipse1);
            compositeGraphic2.Add(ellipse2);
            compositeGraphic2.Add(ellipse3);

            CompositeGraphic compositeGraphic = new CompositeGraphic();
            compositeGraphic.Add(ellipse4);

            //Create another graphics that contains two graphics
            CompositeGraphic compositeGraphic3 = new CompositeGraphic();
            compositeGraphic3.Add(compositeGraphic2);
            compositeGraphic3.Add(compositeGraphic);

            //Prints the complete graphic (Four times the string "Ellipse").
            compositeGraphic3.Print();
        }
    }
}

