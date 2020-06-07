using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Ea2_Activity4.Classes
{
    class Superhero
    {

        private String name;

        //decided to go with List instead of the ArrayList like in the milestone
        private List<String> abilities;

        //hero offices
        private List<String> offices;

        //Hero date
        private DateTime birthday;
        private DateTime graduation;
        private String status;
        private DateTime lastDate;

        //Statistics
        private int strength;
        private int dexterity;
        private int vitality;
        private int darkside;

        //Aesthetics
        private Color maskColor;
        private Color suitColor;
        private Color capeColor;
        private String portrait;

        public Superhero(string name, List<string> abilities, List<string> offices, DateTime birthday, DateTime graduation, string status, DateTime lastDate, int strength, int dexterity, int vitality, int darkside, Color maskColor, Color suitColor, Color capeColor, string portrait)
        {
            this.name = name;
            this.abilities = abilities;
            this.offices = offices;
            this.birthday = birthday;
            this.graduation = graduation;
            this.status = status;
            this.lastDate = lastDate;
            this.strength = strength;
            this.dexterity = dexterity;
            this.vitality = vitality;
            this.darkside = darkside;
            this.maskColor = maskColor;
            this.suitColor = suitColor;
            this.capeColor = capeColor;
            this.portrait = portrait;
        }

        public string Name { get => name; set => name = value; }
        public List<string> Abilities { get => abilities; set => abilities = value; }
        public List<string> Offices { get => offices; set => offices = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime Graduation { get => graduation; set => graduation = value; }
        public string Status { get => status; set => status = value; }
        public DateTime LastDate { get => lastDate; set => lastDate = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Vitality { get => vitality; set => vitality = value; }
        public int Darkside { get => darkside; set => darkside = value; }
        public Color MaskColor { get => maskColor; set => maskColor = value; }
        public Color SuitColor { get => suitColor; set => suitColor = value; }
        public Color CapeColor { get => capeColor; set => capeColor = value; }
        public string Portrait { get => portrait; set => portrait = value; }
    }
}
