using Ea2_Activity4.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ea2_Activity4.Forms
{
    public partial class HeroList : Form
    {

        //Didn't realize we had to pass variables down to a different form. So I'm just going to make a new form and just duplicate a panel to pass

        HeroesAssemble Heroes = new HeroesAssemble();
        FileAccessSystem FAM = new FileAccessSystem();
        public HeroList()
        {
            InitializeComponent();
            HeroesAssemble();
        }

        private void HeroesAssemble()
        {
            Heroes.Superheroes.Clear();
            Heroes.Superheroes.AddRange(FAM.HeroesAssemble().Superheroes);
            lb_HeroList.Items.Clear();
            for (int i = 0; i < Heroes.Superheroes.Count; i++)
            {
                lb_HeroList.Items.Add(Heroes.Superheroes[i].Name);
            }
        }

        private void SelectHero(object sender, EventArgs e)
        {
            ListBox sus = (ListBox)sender;
            int index = sus.SelectedIndex;
            if (index < 0)
            {
                index = 0;
            }else if (index>Heroes.Superheroes.Count)
            {
                index = Heroes.Superheroes.Count;
            }
            if (Application.OpenForms.OfType<HeroOverview>().Count()> 2)
            {
                Application.OpenForms.OfType<HeroOverview>().First().Close();
            }
            HeroOverview heeo = new HeroOverview(Heroes.Superheroes[index]);
            heeo.Show();
        }

        private void UpdateSystem(object sender, EventArgs e)
        {
            HeroesAssemble();
        }

        private void ShowMainMenu(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<MainForm>().First().Show();
            this.Close();            
        }
    }
}
