using DesignPattern.AbstractFactoryDemo;
using DesignPattern.Builder;
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
            }
            throw new Exception($"Invalid  {pattern}");
        }
    }
}
