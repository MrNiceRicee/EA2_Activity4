using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ea2_Activity4.Classes
{
    class HeroesAssemble
    {
        List<Superhero> superheroes;

        public HeroesAssemble(List<Superhero> superheroes)
        {
            this.superheroes = superheroes;
        }

        public HeroesAssemble()
        {
            superheroes = new List<Superhero>();
        }

        internal List<Superhero> Superheroes { get => superheroes; set => superheroes = value; }
        public void Add(Superhero h)
        {
            superheroes.Add(h);
        }
        public void Remove(Superhero h)
        {
            superheroes.Remove(h);
        }
    }
}
