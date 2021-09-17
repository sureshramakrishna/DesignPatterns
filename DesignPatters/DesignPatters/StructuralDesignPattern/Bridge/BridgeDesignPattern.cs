using System;

namespace DesignPatters.StructuralDesignPattern.Bridge
{
    // Helps in providing truly decoupled architecture
    public interface IBridge
    {
        void Function1();
        void Function2();
    }

    public class Bridge1 : IBridge
    {
        public void Function1() => Console.WriteLine("Bridge1.Function1");

        public void Function2() => Console.WriteLine("Bridge1.Function2");
    }

    public class Bridge2 : IBridge
    {
        public void Function1() => Console.WriteLine("Bridge2.Function1");

        public void Function2() => Console.WriteLine("Bridge2.Function2");
    }

    public interface IAbstractBridge
    {
        void CallMethod1();
        void CallMethod2();
    }

    public class AbstractBridge : IAbstractBridge
    {
        public IBridge Bridge;

        public AbstractBridge(IBridge bridge)
        {
            Bridge = bridge;
        }

        public void CallMethod1() => Bridge.Function1();

        public void CallMethod2() => Bridge.Function2();
    }
}
