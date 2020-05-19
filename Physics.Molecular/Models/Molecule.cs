using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Molecular.Models
{
    public class Molecule
    {
        public List<Atom> Atoms { get; set; }

        public Molecule(Tuple<string,int>[] atoms)
        {
            Atoms = new List<Atom>();
            foreach (var item in atoms)
            {
                for (int i = 0; i < item.Item2; i++)
                {
                    Atoms.Add(new Atom(item.Item1));
                }
            }
        }

        public override string ToString()
        {
            var result = "";
            foreach (var item in Atoms)
            {
                result += $"{item.Symbol}";
            }
            result += $"\nMass:{Atoms.Select(x => x.Mass).Sum()}";
            return result;
        }
    }
}
