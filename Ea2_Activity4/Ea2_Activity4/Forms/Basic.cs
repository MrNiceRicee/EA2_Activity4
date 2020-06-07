using Ea2_Activity4.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using System.Text.Encodings.Web;

namespace Ea2_Activity4.Forms
{
    public partial class Basic : Form
    {
        String[] Abilities = {"Super Speed", "Super Strength","Flying","X-Ray Vision","Invisibility", "Energy absorption", "Shapeshifting",
                                "Telepathy","TeleKinesis","Teleporation","Regenerative","Super-Stretch","Elementalist",
                                "Heat Ray","Freeze Ray","Phasing"};

        String[] AbilitiesHint = {"Inhuman speeds, reaction and reflexes", "Intense power levels","Able to fly to the sky","See through most objects","Can't be seen with the normal eye",
                                    "Able to take in energy","Change to different organic beings","Be able to read and speak to minds","Able to move things with will of the mind",
                                    "Go anywhere within a range","Able to heal injuries fast","Be able to extend limbs","Control the primal elements","Shoot a powerful heat blast",
                                    "Shoot a powerful cold beam", "Go through things like a ghost"};


        String[] Cities = { "Chicago", "Hong Kong", "London", "Los Angeles", "New York", "Paris", "Manila", "Rome", "San Francisco", "Seoul", "Shanghai", "Sydney", "Washington D.C." };


        FileAccessSystem FAM = new FileAccessSystem();

        List<Panel> Pages = new List<Panel>();

        //see if the app actually closes
        bool closeup = true;

        public Basic()
        {
            InitializeComponent();
            this.FormClosed += Basic_FormClosed;


            this.Size = new Size(500, 550);
            //scrollbar position
            this.hsb_pages.Location = new Point(15, this.Size.Height - this.hsb_pages.Size.Height - 50);
            InitiatePages();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void InitiatePages()
        {
            Pages.Add(pn_Abilities);
            Pages.Add(pn_cities);
            Pages.Add(pn_Dates);
            Pages.Add(pn_Stats);
            Pages.Add(pn_Aesthetic);
            Pages.Add(pn_HeroCreation);
            this.hsb_pages.Maximum = Pages.Count - 1;
            this.lb_Cities.SelectedValueChanged += CitiesSelect;

            //Page1
            FillCheckbox();

            //Page2
            Page2();

            //Page 3
            Page3();

            //page 4
            Page4();

            //page 5
            Page5();

            //page 6
            Page6();

            EstablishNavigation();
        }

        private void EstablishNavigation()
        {
            this.pn_navigation.Size = new Size(hsb_pages.Size.Width,25);
            this.pn_navigation.Location = new Point(hsb_pages.Location.X,hsb_pages.Location.Y-this.pn_navigation.Size.Height);
            for (int i = 0; i < Pages.Count; i++)
            {
                Button navigationB = new Button();
                navigationB.Size = new Size(25,this.pn_navigation.Height);
                navigationB.Location = new Point((i*(this.pn_navigation.Size.Width / Pages.Count))+25,0);
                //navigationB.Text = Pages[i].Tag.ToString();
                navigationB.Tag = Pages[i].Tag.ToString();
                navigationB.TextAlign = ContentAlignment.BottomCenter;
                navigationB.BackgroundImage = new Bitmap(FAM.getLibrary("\\Icons\\"+Pages[i].Tag.ToString()+".png"));
                navigationB.BackgroundImageLayout = ImageLayout.Zoom;
                navigationB.FlatAppearance.BorderSize = 0;
                navigationB.FlatStyle = FlatStyle.Flat;

                navigationB.Click += NavigationButtons;

                this.pn_navigation.Controls.Add(navigationB);
            }

        }

        private void Page6()
        {
            this.pn_HeroCreation.Location = this.pn_Abilities.Location;
        }

        private void Page5()
        {
            this.pn_Aesthetic.Location = this.pn_Abilities.Location;
            this.piB_Profile.BackgroundImage = new Bitmap(FAM.getLibrary("\\SaveData\\HeroProfiles\\Hero_1.png"));
            this.piB_Profile.Tag = FAM.getLibrary("\\SaveData\\HeroProfiles\\Hero_1.png");
            FillProfilePic();
        }

        private void Page4()
        {
            this.pn_Stats.Location = this.pn_Abilities.Location;
        }

        private void Page3()
        {
            this.pn_Dates.Location = new Point(15, 50);
            //decided to make graduation date today as default.
            this.DTP_Grad.Value = DateTime.Today;
        }
        private void Page2()
        {
            this.pn_cities.Location = new Point(15, 50);
            lb_Cities.Items.Clear();
            lb_Cities.Items.AddRange(Cities);
            this.pn_cities.Size = new Size(this.pn_cities.Size.Width,this.pn_cities.Size.Height+(pn_navigation.Location.Y-this.pn_cities.Size.Height-50));
        }

        private void CreateHero()
        {
            //have to check parameters are met first
            List<CheckBox> SuperPowerList = gb_Abilities.Controls.OfType<CheckBox>().Where(x => x.Checked == true).ToList();
            if (tb_HeroName.Text != "Enter Hero Name")
            {
                if (SuperPowerList.Count > 0)
                {
                    if (lb_Cities.SelectedItems.Count > 0)
                    {
                        if ((RB_Active.Checked) || (RB_ReDD.Checked) || (RB_Retirement.Checked))
                        {
                            //find all the radio buttons, check which is checked, get the first one and then its text
                            String status = pn_Dates.Controls.OfType<RadioButton>().Where(x => x.Checked).First().Text;
                            if (trb_Dexterity.Value + trb_Strength.Value + trb_Vitality.Value == 100)
                            {
                                btn_CreateHero.Text = "Creating " + tb_HeroName.Text;


                                //gather things from list
                                //super power
                                List<String> superpowers = new List<string>();
                                foreach (var item in SuperPowerList)
                                {
                                    superpowers.Add(item.Text);
                                }
                                //offices
                                List<String> offices = new List<string>();
                                foreach (var item in lb_Cities.SelectedItems)
                                {
                                    offices.Add(item.ToString());
                                }
                                List<Superhero> heroAssembly = new List<Superhero>(FAM.HeroesAssemble().Superheroes);
                                if (heroAssembly.Where(x=>x.Name.Equals(tb_HeroName.Text)).Count() > 0)
                                {
                                    btn_CreateHero.Text = "There is already a hero named "+tb_HeroName.Text;
                                }else
                                {
                                    Superhero newHero = new Superhero(tb_HeroName.Text, superpowers, offices, DTP_Bday.Value, DTP_Grad.Value, status, DTP_ReDD.Value, trb_Strength.Value,
                                    trb_Dexterity.Value, trb_Vitality.Value, trB_DarkSide.Value,
                                    btn_MaskColor.FlatAppearance.BorderColor, btn_SuitColor.FlatAppearance.BorderColor, btn_CapeColor.FlatAppearance.BorderColor,
                                    piB_Profile.Tag.ToString());

                                    string heroJson = JsonConvert.SerializeObject(newHero, Formatting.None);
                                    FAM.saveJsonSaveFile(heroJson);
                                    Console.WriteLine(heroJson);
                                    btn_CreateHero.Text = "Created " + tb_HeroName.Text;
                                }



                                //Clear all items

                            }
                            else
                            {
                                btn_CreateHero.Text = "Please allocate all points";
                            }
                        }
                        else
                        {
                            btn_CreateHero.Text = "Please fix the dates";
                        }
                    }
                    else
                    {
                        btn_CreateHero.Text = "Please add an office";
                    }
                }
                else
                {
                    btn_CreateHero.Text = "Please add a super power";
                }
            }
            else
            {
                btn_CreateHero.Text = "Please name the hero";
            }
        }


        //updates the herocreation list
        private void UpdateCreation()
        {
            //clear out the list and then add
            LiB_SuperPowers.Items.Clear();
            LiB_Offices.Items.Clear();
            LiB_Dates.Items.Clear();
            LiB_Statistics.Items.Clear();
            //Set up titles
            LiB_SuperPowers.Items.Add("Hero Super Powers:");
            LiB_Offices.Items.Add("Hero Offices:");
            LiB_Dates.Items.Add("Hero Dates:");
            LiB_Statistics.Items.Add("Hero Statistics");
            if (!tb_HeroName.Text.Equals("Enter Hero Name"))
            {
                btn_HeroLabel.Text = tb_HeroName.Text + " Overview";

            }

            //Add to the List

            //Abilities gather
            List<CheckBox> SuperPowerList = gb_Abilities.Controls.OfType<CheckBox>().Where(x => x.Checked == true).ToList();
            foreach (var item in SuperPowerList)
            {
                LiB_SuperPowers.Items.Add("-" + item.Text);
            }

            //Offices gather
            foreach (var item in lb_Cities.SelectedItems)
            {
                LiB_Offices.Items.Add("-" + item);
            }

            if (SuperPowerList.Count==0)
            {
                LiB_SuperPowers.Items.Add("Please select super power(s)");
            }

            if(lb_Cities.SelectedItems.Count == 0)
            {
                LiB_Offices.Items.Add("Please select operational office(s)");
            }

            //Dates gather
            if ((RB_Active.Checked) || (RB_ReDD.Checked) || (RB_Retirement.Checked))
            {
                LiB_Dates.Items.Add("-Birth Date: " + DTP_Bday.Value.Day + "/" + DTP_Bday.Value.Month + "/" + DTP_Bday.Value.Year);
                LiB_Dates.Items.Add("-Graduation Date: " + DTP_Grad.Value.Day + "/" + DTP_Grad.Value.Month + "/" + DTP_Grad.Value.Year);
                if (RB_Active.Checked)
                {
                    LiB_Dates.Items.Add("-Currently Active");
                } else if (RB_Retirement.Checked)
                {
                    LiB_Dates.Items.Add("-Retirement Date: " + DTP_ReDD.Value.Day + "/" + DTP_ReDD.Value.Month + "/" + DTP_ReDD.Value.Year);
                }
                else if (RB_ReDD.Checked)
                {
                    LiB_Dates.Items.Add("-Fateful Date: " + DTP_ReDD.Value.Day + "/" + DTP_ReDD.Value.Month + "/" + DTP_ReDD.Value.Year);
                }
            }
            else
            {
                LiB_Dates.Items.Add("Please Fix Dates");
            }

            //Stats gather
            if (trb_Dexterity.Value+trb_Strength.Value+trb_Vitality.Value == 100)
            {
                LiB_Statistics.Items.Add("-Strength: " + trb_Strength.Value);
                LiB_Statistics.Items.Add("-Dexterity: " + trb_Dexterity.Value);
                LiB_Statistics.Items.Add("-Vitality: " + trb_Vitality.Value);
                LiB_Statistics.Items.Add("-DarkSide: " + trB_DarkSide.Value);
            }
            else
            {
                LiB_Statistics.Items.Add("There are still "+(100-(trb_Dexterity.Value + trb_Strength.Value + trb_Vitality.Value)));
                LiB_Statistics.Items.Add("points to be allocated");
            }


            //Aesthetics Gather
            btn_CapeColorCreation.FlatAppearance.BorderColor = btn_CapeColor.FlatAppearance.BorderColor;
            btn_MaskColorCreation.FlatAppearance.BorderColor = btn_MaskColor.FlatAppearance.BorderColor;
            btn_SuitColorCreation.FlatAppearance.BorderColor = btn_SuitColor.FlatAppearance.BorderColor;
            PiB_ProfileHeroCreation.BackgroundImage = piB_Profile.BackgroundImage;

        }

        //gathers the pictures in the directory and puts it in the profile selection
        private void FillProfilePic()
        {
            int counter = 0;
            int nexttable = 0;
            var Location = Directory.GetFiles(FAM.getLibrary("\\SaveData\\HeroProfiles"));
            int maxt = 0;
            for (int i = 0; i < Location.Length; i++)
            {
                if (i%3 == 0)
                {
                    maxt++;
                }
            }
            foreach (var item in Location)
            {
                Button bp = new Button();

                bp.Size = new Size(gB_Pictures.Size.Width/3,(gB_Pictures.Size.Height/maxt)-(20/maxt));
                bp.FlatStyle = FlatStyle.Flat;
                bp.BackgroundImageLayout = ImageLayout.Stretch;
                if (counter >0 && counter%3 == 0)
                {
                    nexttable++;
                }
                bp.Location = new Point((counter%3)*bp.Size.Width,nexttable*bp.Size.Height+20);
                bp.BackgroundImage = new Bitmap(item.ToString());
                bp.Tag = item.ToString();

                bp.Click += ProfilePicButton;
                this.gB_Pictures.Controls.Add(bp);
                counter++;
            }
            tb_hint.Location = new Point(this.gb_Abilities.Size.Width+10,this.gb_Abilities.Location.Y+7);
        }



        private void FillPictures()
        {
            int counter = 0;
            //Clear the pictures first
            foreach (var item in this.pn_cities.Controls.OfType<PictureBox>())
            {
                this.pn_cities.Controls.Remove(item);
            }
            //add pictures again
            foreach (var item in lb_Cities.SelectedItems)
            {
                //Console.WriteLine(item.ToString());
                Bitmap picture = FAM.getImage(item.ToString().Replace(" ","").Replace(".",""));
                PictureBox citypic = new PictureBox();

                citypic.Size = new Size(350, 100);
                citypic.Location = new Point(this.lb_Cities.Width, (counter * 100)+15);
                citypic.BackgroundImage = picture;
                citypic.BackgroundImageLayout = ImageLayout.Center;
                counter++;
                this.pn_cities.Controls.Add(citypic);
            }
        }
        //Some Form creation
        private void FillCheckbox()
        {
            this.pn_Abilities.Location = new Point(15,50);
            this.gb_Abilities.Size = new Size(250, 30 + (Abilities.Length * 20));
            this.pn_Abilities.Size +=  new Size(50+ this.gb_Abilities.Size.Width, 40);
            for (int i = 0; i < Abilities.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = Abilities[i];
                checkBox.Location = new Point(10,20+(i*20));
                checkBox.AutoSize = true;
                checkBox.MouseHover += PowerHintHover;
                checkBox.MouseLeave += PowerHintLeave;


                this.gb_Abilities.Controls.Add(checkBox);
            }
        }


        //Number limiter for the sliders

        private int StatBoundaries(int numberchanging, string component)
        {
            //The commented is when I wanted to test if functionally changing the maximum would change user experience.
            //after a couple runs. It got annoying so took it out.
            int determined = numberchanging, total, tbr=determined;
            if (component.Equals("Str"))
            {
                total = trb_Dexterity.Value + trb_Vitality.Value;
                if (determined+total> 100)
                {
                    tbr = 100-total;
                    if (tbr < 0)
                    {
                        tbr = 0;
                    }
                }
/*                int temp1 = trb_Dexterity.Value;
                int temp2 = trb_Vitality.Value;
                trb_Dexterity.Maximum = 100 - (determined + temp2);
                trb_Vitality.Maximum = 100 - (determined + temp1);*/
            }else if (component.Equals("Dex"))
            {
                total = trb_Strength.Value + trb_Vitality.Value;
                if (determined + total > 100)
                {
                    tbr = 100 - total;
                    if (tbr < 0)
                    {
                        tbr = 0;
                    }
                }
/*                int temp1 = trb_Strength.Value;
                int temp2 = trb_Vitality.Value;
                trb_Strength.Maximum = 100 - (temp2+determined);
                trb_Vitality.Maximum = 100 - (temp1+determined);*/
            }else if (component.Equals("Vit"))
            {
                total = trb_Strength.Value + trb_Dexterity.Value;
                if (determined + total > 100)
                {
                    tbr = 100 - total;
                    if (tbr < 0)
                    {
                        tbr = 0;
                    }
                }
/*                int temp1 = trb_Strength.Value;
                int temp2 = trb_Dexterity.Value;
                trb_Strength.Maximum = 100 - (temp2 + determined);
                trb_Dexterity.Maximum = 100 -(temp1+determined);*/
            }
            return tbr;
        }


        //listeners

        //Textbox listener
        private void HeroText_Hint(object sender, EventArgs e)
        {
            if (tb_HeroName.Text.Equals("Enter Hero Name"))
            {
                tb_HeroName.Text = "";

                tb_HeroName.ForeColor = Color.FromArgb(200, 200, 200);
            }else if (tb_HeroName.Text.Equals(""))
            {
                tb_HeroName.Text = "Enter Hero Name";

                tb_HeroName.ForeColor = Color.FromArgb(80, 80, 100);
            }
        }

        //when app closes
        private void Basic_FormClosed(object sender, FormClosedEventArgs e)
        {
            //close the app if it actually closes. Prevents an exe from still being active.
            if (closeup)
            {
                Environment.Exit(0);
            }
        }
        //go back to main menu
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button sus = (Button)sender;
            if (sus.Name.Equals(this.btn_back.Name))
            {
                closeup = false;
                Application.OpenForms.OfType<MainForm>().First().Show();
                this.Close();
            }
        }

        private void HScrolling(object sender, ScrollEventArgs e)
        {
            HScrollBar sus = (HScrollBar)sender;
            Pages[sus.Value].BringToFront();
            UpdateCreation();
            pn_navigation.BringToFront();
            for (int i = 0; i < Pages.Count; i++)
            {
                if (i != sus.Value)
                {
                    Pages[i].Visible = false;
                }
                else
                {
                    Pages[i].Visible = true;
                }
            }
            //Console.WriteLine(sus.Value);
        }

        private void HScrollingChange(object sender, EventArgs e)
        {
            HScrollBar sus = (HScrollBar)sender;
            Pages[sus.Value].BringToFront();
            UpdateCreation();
            pn_navigation.BringToFront();
            for (int i = 0; i < Pages.Count; i++)
            {
                if (i != sus.Value)
                {
                    Pages[i].Visible = false;
                }
                else
                {
                    Pages[i].Visible = true;
                }
            }
            //Console.WriteLine(sus.Value);
        }

        private void CitiesSelect(object sender, EventArgs e)
        {
            FillPictures();
            FillPictures();
        }

        //Retirement/Time of Death

        private void DateRadios(object sender, EventArgs e)
        {
            RadioButton sus = (RadioButton)sender;
            if (sus.Name.Equals(RB_Active.Name))
            {
                //Console.WriteLine("Active");
                lb_reDD.Visible = false;
                DTP_ReDD.Visible = false;
            }else if (sus.Name.Equals(RB_Retirement.Name))
            {
                //Console.WriteLine("Retire");
                lb_reDD.Visible = true;
                lb_reDD.Text = "Retirement";
                DTP_ReDD.Visible = true;
            }
            else if (sus.Name.Equals(RB_ReDD.Name))
            {
                //Console.WriteLine("Dead");
                lb_reDD.Visible = true;
                lb_reDD.Text = "Fateful Day";
                DTP_ReDD.Visible = true;
            }
        }

        private void SliderChanged(object sender, EventArgs e)
        {
            TrackBar sus = (TrackBar)sender;
            if (sus.Name.Equals(this.trb_Strength.Name))
            {
                int x  = StatBoundaries(sus.Value, "Str");
                this.nud_Strength.Value = x;
                trb_Strength.Value = x;
            }
            else if (sus.Name.Equals(this.trb_Dexterity.Name))
            {
                int x = StatBoundaries(sus.Value, "Dex");
                this.nud_Dexterity.Value = x;
                trb_Dexterity.Value = x;
            }
            else if (sus.Name.Equals(this.trb_Vitality.Name))
            {
                int x = StatBoundaries(sus.Value, "Vit");
                this.nud_Vitality.Value = x;
                trb_Vitality.Value = x;
            }
            else if (sus.Name.Equals(this.trB_DarkSide.Name))
            {
                this.lb_Darkside.Text = "Dark Side Propensity: "+trB_DarkSide.Value;
            }
        }

        private void NumericalChange(object sender, EventArgs e)
        {
            NumericUpDown sus = (NumericUpDown)sender;
            if (sus.Name.Equals(this.nud_Strength.Name))
            {
                /*                int x = StatBoundaries(int.Parse(this.nud_Strength.Value.ToString()),"Str");
                                this.trb_Strength.Value = x;*/
                this.trb_Strength.Value = int.Parse(sus.Value.ToString());
            } 
            else if (sus.Name.Equals(this.nud_Dexterity.Name)){
                this.trb_Dexterity.Value = int.Parse(sus.Value.ToString());
            }
            else if (sus.Name.Equals(this.nud_Vitality.Name)){
                this.trb_Vitality.Value = int.Parse(sus.Value.ToString());
            }
        }

        private void ColorPicker(object sender, EventArgs e)
        {
            Button sus = (Button)sender;
            ColorDialog colorpick = new ColorDialog();

            colorpick.AllowFullOpen = false;
            colorpick.ShowHelp = true;
            colorpick.Color = sus.ForeColor;

            if (colorpick.ShowDialog() == DialogResult.OK)
            {
                sus.FlatAppearance.BorderColor = colorpick.Color;
            }
        }

        private void ProfilePicButton(object sender, EventArgs e)
        {
            Button sus = (Button)sender;
            this.piB_Profile.BackgroundImage = sus.BackgroundImage;
            this.piB_Profile.Tag = sus.Tag;
        }

        private void CreationShow(object sender, EventArgs e)
        {
            UpdateCreation();
        }

        private void NavigationButtons(object sender, EventArgs e)
        {
            Button sus = (Button)sender;
            int index = Pages.IndexOf(Pages.Where(x=> x.Tag == sus.Tag).FirstOrDefault());
            hsb_pages.Value = index;
            //Console.WriteLine(Pages[index].Name);
        }

        private void PowerHintHover(object sender, EventArgs e)
        {
            CheckBox sus = (CheckBox)sender;
            tb_hint.Visible = true;
            int index = Array.FindIndex(Abilities, x => x.Equals(sus.Text));
            tb_hint.Text = AbilitiesHint[index];
            Console.WriteLine(sus.Text+" index:"+index);

        }

        private void PowerHintLeave(object sender, EventArgs e)
        {
            CheckBox sus = (CheckBox)sender;
            tb_hint.Visible = false;
            tb_hint.Text = "";
        }

        private void CreateHeroButton(object sender, EventArgs e)
        {
            CreateHero();
        }
    }
}
