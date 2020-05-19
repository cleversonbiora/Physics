using Physics.Molecular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Molecular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Molecule(
                new Tuple<string, int>[] {
                    new Tuple<string, int>("H", 2),
                    new Tuple<string, int>("O", 1)
                }));
            Console.ReadKey();
            
        }
    }
}

//https://pt.wikipedia.org/wiki/Ficheiro:Standard_Model_of_Elementary_Particles.svg
//https://pt.wikipedia.org/wiki/Pr%C3%B3ton
//https://pt.wikipedia.org/wiki/El%C3%A9tron