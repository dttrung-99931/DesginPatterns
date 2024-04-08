using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    public class CompositeDemo : DesignPatternDemo
    {
        public override void Demo()
        {
            Widget text1 = new Text("Text1");
            text1.Render();
            Console.WriteLine();
            Widget text2 = new Text("Text2");
            Widget column = new Column(new List<Widget>() { text1, text2 });
            column.Render();
        }

        public abstract class Widget
        {
            abstract public void Render();
        }

        public class Text : Widget
        {
            public string Value { get; set; }
            public Text(string value)
            {
                Value = value;
            }
            public override void Render()
            {
                Console.Write(Value);
            }
        }

        // Composite class
        public class Column: Widget
        {
            public List<Widget> Children { get; set; }
            public Column(List<Widget> children)
            {
                Children = children;
            }

            public override void Render()
            {
                Console.Write("[");
                Children.ForEach(child =>
                {
                    child.Render();
                    Console.Write(", ");
                });
                Console.WriteLine("]");
            }
        }
    }
}
