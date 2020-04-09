using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IComputerBuilder builder =  null;
            var computerType = Console.ReadLine();
            switch (computerType)
            {
                case "home":
                    builder = new HomeComputer();
                    break;
                case "office":
                    builder = new OfficeComputer();
                    break;
                case "developer":
                    builder = new DeveloperComputer();
                    break;

                default:
                    Console.WriteLine("Invalid computer type");
                    break;
            }

            ComputerAssembler assembler = new ComputerAssembler(builder);
            var computer = assembler.AssembleComputer();
            Console.WriteLine(computer.ToString());
                
        }
    }
}
