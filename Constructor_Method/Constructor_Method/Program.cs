using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor_Method
{
    class Program
    {
        private double Length;
        public Program(double len)
        {
            Console.WriteLine("Object is being created, length = {0}", len);
            Length = len;
        }

        public void setLength(double len)
        {
            Length = len;
        }
        public double getLength()
        {
            return Length;
        }
        static void Main(string[] args)
        {
            
            Program prog = new Program(10.0);
            Console.WriteLine("Length of line : {0}", prog.getLength());
            prog.setLength(6.0);
            Console.WriteLine("Length of line : {0}", prog.getLength());
            Console.ReadKey();

        }
    }
}
