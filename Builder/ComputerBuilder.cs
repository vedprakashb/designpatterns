using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Builder
{
    public class Computer
    {
        public string Cabinet { get; set; }
        public string CPU { get; set; }
        public string Memory { get; set; }
        public string Mouse { get; set; }
        public string KeyBoard { get; set; }
        public string Monitor { get; set; }

        private PropertyInfo[] _PropertyInfos = null;

        public override string ToString()
        {
            if (_PropertyInfos == null)
                _PropertyInfos = this.GetType().GetProperties();

            var sb = new StringBuilder();

            foreach (var info in _PropertyInfos)
            {
                var value = info.GetValue(this, null) ?? "(null)";
                sb.AppendLine(info.Name + ": " + value.ToString());
            }

            return sb.ToString();
        }

    }
    public interface IComputerBuilder
    {
        void AddCpu();
        void AddCabinet();
        void AddMouse();
        void AddKeyBoard();
        void AddMonitor();
        void AddMemory();
        Computer GetComputer();
    }
    public class ComputerAssembler
    {
        IComputerBuilder builder;
        public ComputerAssembler(IComputerBuilder computerBuilder)
        {
            builder = computerBuilder;
        }
        public Computer AssembleComputer()
        {
            builder.AddCabinet();
            builder.AddCpu();
            builder.AddMemory();
            builder.AddMonitor();
            builder.AddKeyBoard();
            builder.AddMouse();
            return builder.GetComputer();
        }
    }
    public class HomeComputer : IComputerBuilder
    {
        Computer computer;
        public HomeComputer()
        {
            computer = new Computer();
        }
        public void AddCabinet()
        {
            computer.Cabinet = "Cabinet for Home";
        }

        public void AddCpu()
        {
            computer.CPU = "CPU for Home COore i3 Processor";

        }

        public void AddKeyBoard()
        {
            computer.KeyBoard = "KeyBoard for Home ";
        }

        public void AddMemory()
        {
            computer.Memory = "Memory for Home 4gb DDR3 RAM";

        }

        public void AddMonitor()
        {
            computer.Monitor = "Monitor for Home 21' CRT Monitor";
        }

        public void AddMouse()
        {
            computer.Mouse = "Mouse for Home Black color wired mouse";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
    public class OfficeComputer : IComputerBuilder
    {
        Computer computer;
        public OfficeComputer()
        {
            computer = new Computer();
        }
        public void AddCabinet()
        {
            computer.Cabinet = "Cabinet for Office";
        }

        public void AddCpu()
        {
            computer.CPU = "CPU for Office COore i5 Processor";

        }

        public void AddKeyBoard()
        {
            computer.KeyBoard = "KeyBoard for Office ";
        }

        public void AddMemory()
        {
            computer.Memory = "Memory for Office 8gb DDR3 RAM";

        }

        public void AddMonitor()
        {
            computer.Monitor = "Monitor for Office 21' LCD Monitor";
        }

        public void AddMouse()
        {
            computer.Mouse = "Mouse for Office Black color wired mouse";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
    public class DeveloperComputer : IComputerBuilder
    {
        Computer computer;
        public DeveloperComputer()
        {
            computer = new Computer();
        }
        public void AddCabinet()
        {
            computer.Cabinet = "Cabinet for Developer";
        }

        public void AddCpu()
        {
            computer.CPU = "CPU for Developer COore i7 Processor";

        }

        public void AddKeyBoard()
        {
            computer.KeyBoard = "KeyBoard for Developer ";
        }

        public void AddMemory()
        {
            computer.Memory = "Memory for Developer 16gb DDR3 RAM";

        }

        public void AddMonitor()
        {
            computer.Monitor = "Monitor for Developer 21' LCD Monitor";
        }

        public void AddMouse()
        {
            computer.Mouse = "Mouse for Developer Black color wired mouse";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
