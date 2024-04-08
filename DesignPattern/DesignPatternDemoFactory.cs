using DesignPattern.AbstractFactoryDemo;
using DesignPattern.Builder;
using DesignPattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class DesignPatternDemo
    {
        public abstract void Demo();
    }

    public enum DesignPatterns
    {
        Builder,
        Factory,
        FactoryMethod,
        Composite,
        Facade,
    }

    public class DesignPatternDemoFactory
    {
        static public DesignPatternDemo createDemo(DesignPatterns pattern)
        {
            switch (pattern)
            {
                case DesignPatterns.Factory:
                    return new FactoryDemo();
                case DesignPatterns.FactoryMethod:
                    return new FactoryMethodDemo();
                case DesignPatterns.Builder:
                    return new BuilderDemo();
                case DesignPatterns.Composite:
                    return new CompositeDemo();
                case DesignPatterns.Facade:
                    return new FacadeDemo();
            }
            throw new Exception($"Invalid  {pattern}");
        }
    }
}
