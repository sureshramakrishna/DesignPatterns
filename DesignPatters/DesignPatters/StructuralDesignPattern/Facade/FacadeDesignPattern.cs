using System;

namespace DesignPatters.StructuralDesignPattern.Facade
{
    public class SubModuleOne
    {
        public void Build() => Console.WriteLine("Building..");
    }
    public class SubModuleTwo
    {
        public void Paint() => Console.WriteLine("Painting..");
    }
    public class SubModuleThree
    {
        public void Shine() => Console.WriteLine("Making it shine..");
    }
    public class FacadeDesignPattern
    {
        private readonly SubModuleOne _subModuleOne;
        private readonly SubModuleTwo _subModuleTwo;
        private readonly SubModuleThree _subModuleThree;
        public FacadeDesignPattern()
        {
            _subModuleOne = new SubModuleOne();
            _subModuleTwo = new SubModuleTwo();
            _subModuleThree = new SubModuleThree();
        }
        public void Build() => _subModuleOne.Build();
        public void Paint() => _subModuleTwo.Paint();
        public void Shine() => _subModuleThree.Shine();
    }
}