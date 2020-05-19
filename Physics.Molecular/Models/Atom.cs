using Physics.Molecular.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Molecular.Models
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public decimal Mass { get; set; }
        public AtomType Type { get; set; }

        public Atom(string symbol)
        {
            Symbol = symbol;
            switch (symbol)
            {
                case "He":
                    Number = 2;
                    Mass = 4.003m;
                    Type = AtomType.GasesNobre;
                    break;
                case "O":
                    Number = 8;
                    Mass = 15.999m;
                    Type = AtomType.NaoMetal;
                    break;
                case "H":
                default:
                    Number = 1;
                    Mass = 1.008m;
                    Type = AtomType.NaoMetal;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Symbol}\nMass:{Mass}";
        }
    }
}
