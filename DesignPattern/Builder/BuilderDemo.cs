using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class BuilderDemo : DesignPatternDemo
    {
        public override void Demo()
        {
            PC myPC = new PCBuilder()
                .SetRam(Memory._16GB)
                .SetStorage(Memory._64GB)
                .SetScreen(new Screen(Resolution._720px, Resolution._1280px))
                .Build();
            myPC.ShowInfo();
        }
    }

    public class PCBuilder: IPCBuilder
    {
        private Memory _ram;
        private Memory _storage { get; set; }
        private Screen _screen { get; set; }

        public PC Build()
        {
            return new PC(_ram, _storage, _screen);
        }

        public IPCBuilder SetRam(Memory memory)
        {
            _storage = memory;
            return this;
        }

        public IPCBuilder SetScreen(Screen screen)
        {
            _screen = screen;
            return this;
        }

        public IPCBuilder SetStorage(Memory memory)
        {
            _ram = memory;
            return this;
        }
    }

    public interface IPCBuilder
    {
        public abstract IPCBuilder SetRam(Memory memory);
        public abstract IPCBuilder SetStorage(Memory memory);
        public abstract IPCBuilder SetScreen(Screen screen);
        public abstract PC Build();
    }



    public class PC
    {
        public PC(Memory ram, Memory storage, Screen screen)
        {
            Ram = ram;
            Storage = storage;
            Screen = screen;
        }

        public Memory Ram { get; set; }
        public Memory Storage { get; set; }
        public Screen Screen { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Ram {Ram}, Storage {Storage}, Screen {Screen}");
        }
    }

    public enum Memory { _4GB = 4, _8GB = 8, _16GB = 16, _32GB = 32, _64GB = 64 }
    public enum Resolution { _720px = 720,  _1280px = 1280, _1080px = 1080 }
    public class Screen
    {
        public Screen(Resolution width, Resolution height)
        {
            this.width = width;
            this.height = height;
        }

        public Resolution width { get; set; }
        public Resolution height { get; set; }
    }

}
