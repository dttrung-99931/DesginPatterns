using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    public class FacadeDemo : DesignPatternDemo
    {
        public override void Demo()
        {
            Console.WriteLine("Facade design pattern like wrapper utils class. \n" +
                "Ex: There's 3 converter: AUdioConverter, VideoConverter, ImageConverter\n" +
                "We defind:\n" +
                "class Converter {\n" + // <- facade class
                    "   File convertAudio() { ... }\n" +
                    "   File convertImage() { ... }\n" +
                    "   File convertVideo() { ... }\n" +
                "}"); 
        }
    }
}
