using System;

namespace DesignPatters.StructuralDesignPattern.Decorator
{
    public interface ICircle
    {
        public void Draw();
    }
    public class Circle : ICircle
    {
        public void Draw() => Console.WriteLine("Drawing circle!");
    }
    public abstract class Decorator : ICircle
    {
        private ICircle _circle;
        protected Decorator(ICircle circle) => _circle = circle;
        public virtual void Draw() => _circle.Draw();
    }
    public class DrawCircleBorder : Decorator
    {
        public DrawCircleBorder(ICircle circle) : base(circle)
        {
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing Border!");
        }
    }
    public class FillCircle : Decorator
    {
        public FillCircle(ICircle circle) : base(circle)
        {
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Filled circle with Color!");
        }
    }
    public class DecoratorDesignPattern
    {
        public void Demo()
        {
            ICircle circle = new Circle();
            Decorator d = new FillCircle(new DrawCircleBorder(circle));
            d.Draw();
        }
    }
}