using System;
using System.Collections.Generic;

namespace DesignPatters.StructuralDesignPattern.FlyWeight
{
    public interface Shape
    {
        void Draw();
    }
    public class Circle : Shape
    {
        public string Color { get; set; }
        private int _x = 10;
        private int _y = 20;
        private int _radius = 30;

        public void SetColor(string color)
        {
            Color = color;
        }
        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + _x + ", Y Cor :" + _y + ", Radius :" + _radius);
        }

    }
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();
        public static Shape GetShape(string shapeType)
        {
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (!shapeMap.TryGetValue("circle", out var shape))
                    shapeMap["circle"] = shape = new Circle();
                return shape;
            }

            return null;
        }
    }
    public class FlyWeightDesignPattern
    {
        public void Demo()
        {
            Console.WriteLine("\n Red color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Red");
                circle.Draw();
            }
        }
    }
}