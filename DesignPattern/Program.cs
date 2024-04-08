// See https://aka.ms/new-console-template for more information
using DesignPattern;

DesignPatternDemo demo = DesignPatternDemoFactory.createDemo(DesignPatterns.Facade);

Console.WriteLine(demo.GetType().Name);
demo.Demo();