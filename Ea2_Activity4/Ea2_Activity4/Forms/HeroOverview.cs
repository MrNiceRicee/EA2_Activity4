using Ea2_Activity4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ea2_Activity4.Forms
{
    public partial class HeroOverview : Form
    {
        internal HeroOverview(Superhero h)
        {
            InitializeComponent();
            HOverview(h);
        }
        private void HOverview(Superhero h)
        {
            LiB_Dates.Items.Clear();
            LiB_Offices.Items.Clear();
            LiB_Statistics.Items.Clear();
            LiB_SuperPowers.Items.Clear();


            this.btn_HeroLabel.Text = h.Name + " Overview";
            this.LiB_SuperPowers.Items.Add("Superpowers:");
            foreach (var item in h.Abilities)
            {
                this.LiB_SuperPowers.Items.Add(item);
            }
            this.LiB_Offices.Items.Add("Offices:");
            foreach (var item in h.Offices)
            {
                this.LiB_Offices.Items.Add(item);
            }
            //stats
            this.LiB_Statistics.Items.Add("Strength: " + h.Strength);
            this.LiB_Statistics.Items.Add("Dexterity: " + h.Dexterity);
            this.LiB_Statistics.Items.Add("Vitality: " + h.Vitality);
            this.LiB_Statistics.Items.Add("Darkside : " + h.Darkside);

            //date
            this.LiB_Dates.Items.Add("Birthday: " + h.Birthday);
            this.LiB_Dates.Items.Add("Graduation: " + h.Graduation);
            if (h.Status.Equals("Retirement"))
            {
                this.LiB_Dates.Items.Add("Retired: " + h.LastDate);

            }
            else if (h.Status.Equals("Deceased"))
            {
                this.LiB_Dates.Items.Add("Fateful day: " + h.LastDate);
            }

            //Color
            btn_CapeColorCreation.FlatAppearance.BorderColor = h.CapeColor;
            btn_MaskColorCreation.FlatAppearance.BorderColor = h.MaskColor;
            btn_SuitColorCreation.FlatAppearance.BorderColor = h.SuitColor;
            PiB_ProfileHeroCreation.BackgroundImage = new Bitmap(h.Portrait);
        }
    }
}
