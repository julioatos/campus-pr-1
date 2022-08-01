using System;

namespace LambdasAndDelegates
{
    public class Delegados
    {
        public Func<int, int, int> suma = (a, b) => a + b;
        public Func<int, int, int> resta = (a, b) => a - b;
        public Action<int> divisionEntreCero = (numero) =>
        {
            if (numero == 0) throw new DivideByZeroException("Intentaste dividir entre 0");

        };
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
