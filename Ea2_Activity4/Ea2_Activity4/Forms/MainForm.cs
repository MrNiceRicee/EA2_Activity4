using Ea2_Activity4.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ea2_Activity4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static string[] jsonString = { "Keep it 100!", "Yeet"};

        string convert = JsonConvert.SerializeObject(jsonString, Formatting.None);




        private void beepbeep(object sender, EventArgs e)
        {
            Button sus = (Button)sender;
            if (sus.Name.Equals(btn_basic.Name))
            {
                if (Application.OpenForms.OfType<Basic>().Count() > 0)
                {
                    Application.OpenForms.OfType<Basic>().First().Close();
                }
                Console.WriteLine("Basic");
                Basic basic = new Basic();
                basic.Show();
                this.Hide();
            }else if (sus.Name.Equals(btn_custom.Name))
            {
                if (Application.OpenForms.OfType<HeroList>().Count() > 0)
                {
                    Application.OpenForms.OfType<HeroList>().First().Close();
                }
                Console.WriteLine("Custom");
                HeroList heroList = new HeroList();
                heroList.Show();
            }
        }
    }
}
