using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorTemplate.Classes;
using VisitorTemplate.Interfaces;

namespace VisitorTemplate
{
    class Program
    {
        public static void Main(string[] args)
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());

            Console.ReadLine();
        }
    }
}
