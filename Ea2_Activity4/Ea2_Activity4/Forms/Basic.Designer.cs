namespace Ea2_Activity4.Forms
{
    partial class Basic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_HeroName = new System.Windows.Forms.TextBox();
            this.gb_Abilities = new System.Windows.Forms.GroupBox();
            this.pn_Abilities = new System.Windows.Forms.Panel();
            this.tb_hint = new System.Windows.Forms.TextBox();
            this.hsb_pages = new System.Windows.Forms.HScrollBar();
            this.pn_cities = new System.Windows.Forms.Panel();
            this.lb_OfficeLocations = new System.Windows.Forms.Label();
            this.lb_Cities = new System.Windows.Forms.ListBox();
            this.pn_Dates = new System.Windows.Forms.Panel();
            this.lb_reDD = new System.Windows.Forms.Label();
            this.DTP_ReDD = new System.Windows.Forms.DateTimePicker();
            this.RB_ReDD = new System.Windows.Forms.RadioButton();
            this.RB_Retirement = new System.Windows.Forms.RadioButton();
            this.RB_Active = new System.Windows.Forms.RadioButton();
            this.lb_Grad = new System.Windows.Forms.Label();
            this.DTP_Grad = new System.Windows.Forms.DateTimePicker();
            this.lb_Birthday = new System.Windows.Forms.Label();
            this.DTP_Bday = new System.Windows.Forms.DateTimePicker();
            this.lb_ImpDates = new System.Windows.Forms.Label();
            this.pn_Stats = new System.Windows.Forms.Panel();
            this.lb_Darkside = new System.Windows.Forms.Label();
            this.trB_DarkSide = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Vitality = new System.Windows.Forms.Label();
            this.lb_Dexterity = new System.Windows.Forms.Label();
            this.lb_Strength = new System.Windows.Forms.Label();
            this.nud_Vitality = new System.Windows.Forms.NumericUpDown();
            this.nud_Dexterity = new System.Windows.Forms.NumericUpDown();
            this.trb_Vitality = new System.Windows.Forms.TrackBar();
            this.trb_Dexterity = new System.Windows.Forms.TrackBar();
            this.trb_Strength = new System.Windows.Forms.TrackBar();
            this.nud_Strength = new System.Windows.Forms.NumericUpDown();
            this.pn_Aesthetic = new System.Windows.Forms.Panel();
            this.gB_Pictures = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_MaskColor = new System.Windows.Forms.Button();
            this.btn_SuitColor = new System.Windows.Forms.Button();
            this.btn_CapeColor = new System.Windows.Forms.Button();
            this.lb_Aesthetics = new System.Windows.Forms.Label();
            this.pn_HeroCreation = new System.Windows.Forms.Panel();
            this.btn_HeroLabel = new System.Windows.Forms.Button();
            this.btn_CreateHero = new System.Windows.Forms.Button();
            this.btn_SuitColorCreation = new System.Windows.Forms.Button();
            this.btn_CapeColorCreation = new System.Windows.Forms.Button();
            this.btn_MaskColorCreation = new System.Windows.Forms.Button();
            this.LiB_Offices = new System.Windows.Forms.ListBox();
            this.LiB_Statistics = new System.Windows.Forms.ListBox();
            this.LiB_Dates = new System.Windows.Forms.ListBox();
            this.LiB_SuperPowers = new System.Windows.Forms.ListBox();
            this.pn_navigation = new System.Windows.Forms.Panel();
            this.PiB_ProfileHeroCreation = new System.Windows.Forms.PictureBox();
            this.piB_Profile = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.piB_Hair = new System.Windows.Forms.PictureBox();
            this.pn_Abilities.SuspendLayout();
            this.pn_cities.SuspendLayout();
            this.pn_Dates.SuspendLayout();
            this.pn_Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_DarkSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vitality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Vitality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Dexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Strength)).BeginInit();
            this.pn_Aesthetic.SuspendLayout();
            this.pn_HeroCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiB_ProfileHeroCreation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Hair)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_HeroName
            // 
            this.tb_HeroName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(68)))));
            this.tb_HeroName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_HeroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HeroName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.tb_HeroName.Location = new System.Drawing.Point(124, 12);
            this.tb_HeroName.Name = "tb_HeroName";
            this.tb_HeroName.Size = new System.Drawing.Size(500, 30);
            this.tb_HeroName.TabIndex = 2;
            this.tb_HeroName.Text = "Enter Hero Name";
            this.tb_HeroName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_HeroName.TextChanged += new System.EventHandler(this.CreationShow);
            this.tb_HeroName.Enter += new System.EventHandler(this.HeroText_Hint);
            this.tb_HeroName.Leave += new System.EventHandler(this.HeroText_Hint);
            // 
            // gb_Abilities
            // 
            this.gb_Abilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Abilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Abilities.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_Abilities.Location = new System.Drawing.Point(3, 3);
            this.gb_Abilities.Name = "gb_Abilities";
            this.gb_Abilities.Size = new System.Drawing.Size(200, 23);
            this.gb_Abilities.TabIndex = 3;
            this.gb_Abilities.TabStop = false;
            this.gb_Abilities.Text = "Special Abilities";
            // 
            // pn_Abilities
            // 
            this.pn_Abilities.AutoScroll = true;
            this.pn_Abilities.Controls.Add(this.tb_hint);
            this.pn_Abilities.Controls.Add(this.gb_Abilities);
            this.pn_Abilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Abilities.Location = new System.Drawing.Point(15, 50);
            this.pn_Abilities.Name = "pn_Abilities";
            this.pn_Abilities.Size = new System.Drawing.Size(555, 369);
            this.pn_Abilities.TabIndex = 4;
            this.pn_Abilities.Tag = "Abilities";
            // 
            // tb_hint
            // 
            this.tb_hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.tb_hint.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_hint.Location = new System.Drawing.Point(345, 10);
            this.tb_hint.Multiline = true;
            this.tb_hint.Name = "tb_hint";
            this.tb_hint.Size = new System.Drawing.Size(207, 265);
            this.tb_hint.TabIndex = 4;
            this.tb_hint.Visible = false;
            // 
            // hsb_pages
            // 
            this.hsb_pages.LargeChange = 1;
            this.hsb_pages.Location = new System.Drawing.Point(15, 425);
            this.hsb_pages.Maximum = 5;
            this.hsb_pages.Name = "hsb_pages";
            this.hsb_pages.Size = new System.Drawing.Size(609, 21);
            this.hsb_pages.TabIndex = 10;
            this.hsb_pages.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrolling);
            this.hsb_pages.ValueChanged += new System.EventHandler(this.HScrollingChange);
            // 
            // pn_cities
            // 
            this.pn_cities.AutoScroll = true;
            this.pn_cities.Controls.Add(this.lb_OfficeLocations);
            this.pn_cities.Controls.Add(this.lb_Cities);
            this.pn_cities.Location = new System.Drawing.Point(599, 48);
            this.pn_cities.Name = "pn_cities";
            this.pn_cities.Size = new System.Drawing.Size(650, 369);
            this.pn_cities.TabIndex = 11;
            this.pn_cities.Tag = "Offices";
            this.pn_cities.Visible = false;
            // 
            // lb_OfficeLocations
            // 
            this.lb_OfficeLocations.AutoSize = true;
            this.lb_OfficeLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OfficeLocations.Location = new System.Drawing.Point(3, 0);
            this.lb_OfficeLocations.Name = "lb_OfficeLocations";
            this.lb_OfficeLocations.Size = new System.Drawing.Size(110, 17);
            this.lb_OfficeLocations.TabIndex = 2;
            this.lb_OfficeLocations.Text = "Office Locations";
            // 
            // lb_Cities
            // 
            this.lb_Cities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.lb_Cities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Cities.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_Cities.FormattingEnabled = true;
            this.lb_Cities.ItemHeight = 16;
            this.lb_Cities.Location = new System.Drawing.Point(3, 19);
            this.lb_Cities.Name = "lb_Cities";
            this.lb_Cities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb_Cities.Size = new System.Drawing.Size(150, 352);
            this.lb_Cities.TabIndex = 1;
            this.lb_Cities.Click += new System.EventHandler(this.CitiesSelect);
            this.lb_Cities.SelectedIndexChanged += new System.EventHandler(this.CitiesSelect);
            // 
            // pn_Dates
            // 
            this.pn_Dates.Controls.Add(this.lb_reDD);
            this.pn_Dates.Controls.Add(this.DTP_ReDD);
            this.pn_Dates.Controls.Add(this.RB_ReDD);
            this.pn_Dates.Controls.Add(this.RB_Retirement);
            this.pn_Dates.Controls.Add(this.RB_Active);
            this.pn_Dates.Controls.Add(this.lb_Grad);
            this.pn_Dates.Controls.Add(this.DTP_Grad);
            this.pn_Dates.Controls.Add(this.lb_Birthday);
            this.pn_Dates.Controls.Add(this.DTP_Bday);
            this.pn_Dates.Controls.Add(this.lb_ImpDates);
            this.pn_Dates.Location = new System.Drawing.Point(45, 444);
            this.pn_Dates.Name = "pn_Dates";
            this.pn_Dates.Size = new System.Drawing.Size(506, 369);
            this.pn_Dates.TabIndex = 12;
            this.pn_Dates.Tag = "Dates";
            this.pn_Dates.Visible = false;
            // 
            // lb_reDD
            // 
            this.lb_reDD.AutoSize = true;
            this.lb_reDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reDD.Location = new System.Drawing.Point(23, 225);
            this.lb_reDD.Name = "lb_reDD";
            this.lb_reDD.Size = new System.Drawing.Size(153, 17);
            this.lb_reDD.TabIndex = 9;
            this.lb_reDD.Text = "Retirement/Fateful Day";
            this.lb_reDD.Visible = false;
            // 
            // DTP_ReDD
            // 
            this.DTP_ReDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ReDD.Location = new System.Drawing.Point(26, 245);
            this.DTP_ReDD.Name = "DTP_ReDD";
            this.DTP_ReDD.Size = new System.Drawing.Size(270, 23);
            this.DTP_ReDD.TabIndex = 8;
            this.DTP_ReDD.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTP_ReDD.Visible = false;
            // 
            // RB_ReDD
            // 
            this.RB_ReDD.AutoSize = true;
            this.RB_ReDD.Location = new System.Drawing.Point(203, 178);
            this.RB_ReDD.Name = "RB_ReDD";
            this.RB_ReDD.Size = new System.Drawing.Size(93, 21);
            this.RB_ReDD.TabIndex = 7;
            this.RB_ReDD.TabStop = true;
            this.RB_ReDD.Text = "Deceased";
            this.RB_ReDD.UseVisualStyleBackColor = true;
            this.RB_ReDD.Click += new System.EventHandler(this.DateRadios);
            // 
            // RB_Retirement
            // 
            this.RB_Retirement.AutoSize = true;
            this.RB_Retirement.Location = new System.Drawing.Point(99, 178);
            this.RB_Retirement.Name = "RB_Retirement";
            this.RB_Retirement.Size = new System.Drawing.Size(98, 21);
            this.RB_Retirement.TabIndex = 6;
            this.RB_Retirement.TabStop = true;
            this.RB_Retirement.Text = "Retirement";
            this.RB_Retirement.UseVisualStyleBackColor = true;
            this.RB_Retirement.Click += new System.EventHandler(this.DateRadios);
            // 
            // RB_Active
            // 
            this.RB_Active.AutoSize = true;
            this.RB_Active.Location = new System.Drawing.Point(26, 178);
            this.RB_Active.Name = "RB_Active";
            this.RB_Active.Size = new System.Drawing.Size(67, 21);
            this.RB_Active.TabIndex = 5;
            this.RB_Active.TabStop = true;
            this.RB_Active.Text = "Active";
            this.RB_Active.UseVisualStyleBackColor = true;
            this.RB_Active.Click += new System.EventHandler(this.DateRadios);
            // 
            // lb_Grad
            // 
            this.lb_Grad.AutoSize = true;
            this.lb_Grad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Grad.Location = new System.Drawing.Point(23, 108);
            this.lb_Grad.Name = "lb_Grad";
            this.lb_Grad.Size = new System.Drawing.Size(114, 17);
            this.lb_Grad.TabIndex = 4;
            this.lb_Grad.Text = "Hero Graduation";
            // 
            // DTP_Grad
            // 
            this.DTP_Grad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Grad.Location = new System.Drawing.Point(26, 128);
            this.DTP_Grad.Name = "DTP_Grad";
            this.DTP_Grad.Size = new System.Drawing.Size(270, 23);
            this.DTP_Grad.TabIndex = 3;
            this.DTP_Grad.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lb_Birthday
            // 
            this.lb_Birthday.AutoSize = true;
            this.lb_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Birthday.Location = new System.Drawing.Point(23, 48);
            this.lb_Birthday.Name = "lb_Birthday";
            this.lb_Birthday.Size = new System.Drawing.Size(60, 17);
            this.lb_Birthday.TabIndex = 2;
            this.lb_Birthday.Text = "Birthday";
            // 
            // DTP_Bday
            // 
            this.DTP_Bday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Bday.Location = new System.Drawing.Point(26, 68);
            this.DTP_Bday.Name = "DTP_Bday";
            this.DTP_Bday.Size = new System.Drawing.Size(270, 23);
            this.DTP_Bday.TabIndex = 1;
            this.DTP_Bday.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lb_ImpDates
            // 
            this.lb_ImpDates.AutoSize = true;
            this.lb_ImpDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ImpDates.Location = new System.Drawing.Point(3, 6);
            this.lb_ImpDates.Name = "lb_ImpDates";
            this.lb_ImpDates.Size = new System.Drawing.Size(129, 20);
            this.lb_ImpDates.TabIndex = 0;
            this.lb_ImpDates.Text = "Important Dates";
            // 
            // pn_Stats
            // 
            this.pn_Stats.Controls.Add(this.lb_Darkside);
            this.pn_Stats.Controls.Add(this.trB_DarkSide);
            this.pn_Stats.Controls.Add(this.label1);
            this.pn_Stats.Controls.Add(this.lb_Vitality);
            this.pn_Stats.Controls.Add(this.lb_Dexterity);
            this.pn_Stats.Controls.Add(this.lb_Strength);
            this.pn_Stats.Controls.Add(this.nud_Vitality);
            this.pn_Stats.Controls.Add(this.nud_Dexterity);
            this.pn_Stats.Controls.Add(this.trb_Vitality);
            this.pn_Stats.Controls.Add(this.trb_Dexterity);
            this.pn_Stats.Controls.Add(this.trb_Strength);
            this.pn_Stats.Controls.Add(this.nud_Strength);
            this.pn_Stats.Location = new System.Drawing.Point(557, 456);
            this.pn_Stats.Name = "pn_Stats";
            this.pn_Stats.Size = new System.Drawing.Size(609, 368);
            this.pn_Stats.TabIndex = 13;
            this.pn_Stats.Tag = "Statistics";
            this.pn_Stats.Visible = false;
            // 
            // lb_Darkside
            // 
            this.lb_Darkside.AutoSize = true;
            this.lb_Darkside.Location = new System.Drawing.Point(4, 288);
            this.lb_Darkside.Name = "lb_Darkside";
            this.lb_Darkside.Size = new System.Drawing.Size(157, 17);
            this.lb_Darkside.TabIndex = 13;
            this.lb_Darkside.Text = "Dark Side Propensity: 0";
            // 
            // trB_DarkSide
            // 
            this.trB_DarkSide.Location = new System.Drawing.Point(3, 308);
            this.trB_DarkSide.Maximum = 100;
            this.trB_DarkSide.Name = "trB_DarkSide";
            this.trB_DarkSide.Size = new System.Drawing.Size(603, 56);
            this.trB_DarkSide.TabIndex = 11;
            this.trB_DarkSide.ValueChanged += new System.EventHandler(this.SliderChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hero Statistics";
            // 
            // lb_Vitality
            // 
            this.lb_Vitality.AutoSize = true;
            this.lb_Vitality.Location = new System.Drawing.Point(3, 172);
            this.lb_Vitality.Name = "lb_Vitality";
            this.lb_Vitality.Size = new System.Drawing.Size(49, 17);
            this.lb_Vitality.TabIndex = 8;
            this.lb_Vitality.Text = "Vitality";
            // 
            // lb_Dexterity
            // 
            this.lb_Dexterity.AutoSize = true;
            this.lb_Dexterity.Location = new System.Drawing.Point(3, 106);
            this.lb_Dexterity.Name = "lb_Dexterity";
            this.lb_Dexterity.Size = new System.Drawing.Size(63, 17);
            this.lb_Dexterity.TabIndex = 7;
            this.lb_Dexterity.Text = "Dexterity";
            // 
            // lb_Strength
            // 
            this.lb_Strength.AutoSize = true;
            this.lb_Strength.Location = new System.Drawing.Point(4, 42);
            this.lb_Strength.Name = "lb_Strength";
            this.lb_Strength.Size = new System.Drawing.Size(62, 17);
            this.lb_Strength.TabIndex = 6;
            this.lb_Strength.Text = "Strength";
            // 
            // nud_Vitality
            // 
            this.nud_Vitality.Location = new System.Drawing.Point(71, 167);
            this.nud_Vitality.Name = "nud_Vitality";
            this.nud_Vitality.Size = new System.Drawing.Size(120, 22);
            this.nud_Vitality.TabIndex = 5;
            this.nud_Vitality.ValueChanged += new System.EventHandler(this.NumericalChange);
            // 
            // nud_Dexterity
            // 
            this.nud_Dexterity.Location = new System.Drawing.Point(72, 104);
            this.nud_Dexterity.Name = "nud_Dexterity";
            this.nud_Dexterity.Size = new System.Drawing.Size(120, 22);
            this.nud_Dexterity.TabIndex = 4;
            this.nud_Dexterity.ValueChanged += new System.EventHandler(this.NumericalChange);
            // 
            // trb_Vitality
            // 
            this.trb_Vitality.Location = new System.Drawing.Point(3, 192);
            this.trb_Vitality.Maximum = 100;
            this.trb_Vitality.Name = "trb_Vitality";
            this.trb_Vitality.Size = new System.Drawing.Size(603, 56);
            this.trb_Vitality.TabIndex = 3;
            this.trb_Vitality.ValueChanged += new System.EventHandler(this.SliderChanged);
            // 
            // trb_Dexterity
            // 
            this.trb_Dexterity.Location = new System.Drawing.Point(3, 126);
            this.trb_Dexterity.Maximum = 100;
            this.trb_Dexterity.Name = "trb_Dexterity";
            this.trb_Dexterity.Size = new System.Drawing.Size(603, 56);
            this.trb_Dexterity.TabIndex = 2;
            this.trb_Dexterity.ValueChanged += new System.EventHandler(this.SliderChanged);
            // 
            // trb_Strength
            // 
            this.trb_Strength.Location = new System.Drawing.Point(3, 63);
            this.trb_Strength.Maximum = 100;
            this.trb_Strength.Name = "trb_Strength";
            this.trb_Strength.Size = new System.Drawing.Size(603, 56);
            this.trb_Strength.TabIndex = 1;
            this.trb_Strength.ValueChanged += new System.EventHandler(this.SliderChanged);
            // 
            // nud_Strength
            // 
            this.nud_Strength.Location = new System.Drawing.Point(72, 40);
            this.nud_Strength.Name = "nud_Strength";
            this.nud_Strength.Size = new System.Drawing.Size(120, 22);
            this.nud_Strength.TabIndex = 0;
            this.nud_Strength.ValueChanged += new System.EventHandler(this.NumericalChange);
            // 
            // pn_Aesthetic
            // 
            this.pn_Aesthetic.Controls.Add(this.piB_Profile);
            this.pn_Aesthetic.Controls.Add(this.gB_Pictures);
            this.pn_Aesthetic.Controls.Add(this.label2);
            this.pn_Aesthetic.Controls.Add(this.btn_MaskColor);
            this.pn_Aesthetic.Controls.Add(this.btn_SuitColor);
            this.pn_Aesthetic.Controls.Add(this.btn_CapeColor);
            this.pn_Aesthetic.Controls.Add(this.lb_Aesthetics);
            this.pn_Aesthetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Aesthetic.Location = new System.Drawing.Point(1184, 452);
            this.pn_Aesthetic.Name = "pn_Aesthetic";
            this.pn_Aesthetic.Size = new System.Drawing.Size(606, 368);
            this.pn_Aesthetic.TabIndex = 14;
            this.pn_Aesthetic.Tag = "Aesthetics";
            this.pn_Aesthetic.Visible = false;
            // 
            // gB_Pictures
            // 
            this.gB_Pictures.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gB_Pictures.Location = new System.Drawing.Point(289, 215);
            this.gB_Pictures.Name = "gB_Pictures";
            this.gB_Pictures.Size = new System.Drawing.Size(314, 149);
            this.gB_Pictures.TabIndex = 8;
            this.gB_Pictures.TabStop = false;
            this.gB_Pictures.Text = "Pictures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Portrait";
            // 
            // btn_MaskColor
            // 
            this.btn_MaskColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btn_MaskColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaskColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaskColor.Location = new System.Drawing.Point(120, 63);
            this.btn_MaskColor.Name = "btn_MaskColor";
            this.btn_MaskColor.Size = new System.Drawing.Size(100, 100);
            this.btn_MaskColor.TabIndex = 3;
            this.btn_MaskColor.Text = "Mask Color";
            this.btn_MaskColor.UseVisualStyleBackColor = false;
            this.btn_MaskColor.Click += new System.EventHandler(this.ColorPicker);
            // 
            // btn_SuitColor
            // 
            this.btn_SuitColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btn_SuitColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuitColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuitColor.Location = new System.Drawing.Point(289, 63);
            this.btn_SuitColor.Name = "btn_SuitColor";
            this.btn_SuitColor.Size = new System.Drawing.Size(100, 100);
            this.btn_SuitColor.TabIndex = 2;
            this.btn_SuitColor.Text = "Suit Color";
            this.btn_SuitColor.UseVisualStyleBackColor = false;
            this.btn_SuitColor.Click += new System.EventHandler(this.ColorPicker);
            // 
            // btn_CapeColor
            // 
            this.btn_CapeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btn_CapeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapeColor.Location = new System.Drawing.Point(449, 63);
            this.btn_CapeColor.Name = "btn_CapeColor";
            this.btn_CapeColor.Size = new System.Drawing.Size(100, 100);
            this.btn_CapeColor.TabIndex = 1;
            this.btn_CapeColor.Text = "Cape Color";
            this.btn_CapeColor.UseVisualStyleBackColor = false;
            this.btn_CapeColor.Click += new System.EventHandler(this.ColorPicker);
            // 
            // lb_Aesthetics
            // 
            this.lb_Aesthetics.AutoSize = true;
            this.lb_Aesthetics.Location = new System.Drawing.Point(15, 8);
            this.lb_Aesthetics.Name = "lb_Aesthetics";
            this.lb_Aesthetics.Size = new System.Drawing.Size(121, 20);
            this.lb_Aesthetics.TabIndex = 0;
            this.lb_Aesthetics.Text = "Hero Aesthetic";
            // 
            // pn_HeroCreation
            // 
            this.pn_HeroCreation.Controls.Add(this.btn_HeroLabel);
            this.pn_HeroCreation.Controls.Add(this.btn_CreateHero);
            this.pn_HeroCreation.Controls.Add(this.btn_SuitColorCreation);
            this.pn_HeroCreation.Controls.Add(this.btn_CapeColorCreation);
            this.pn_HeroCreation.Controls.Add(this.btn_MaskColorCreation);
            this.pn_HeroCreation.Controls.Add(this.PiB_ProfileHeroCreation);
            this.pn_HeroCreation.Controls.Add(this.LiB_Offices);
            this.pn_HeroCreation.Controls.Add(this.LiB_Statistics);
            this.pn_HeroCreation.Controls.Add(this.LiB_Dates);
            this.pn_HeroCreation.Controls.Add(this.LiB_SuperPowers);
            this.pn_HeroCreation.Location = new System.Drawing.Point(1275, 53);
            this.pn_HeroCreation.Name = "pn_HeroCreation";
            this.pn_HeroCreation.Size = new System.Drawing.Size(626, 368);
            this.pn_HeroCreation.TabIndex = 15;
            this.pn_HeroCreation.Tag = "Overview";
            this.pn_HeroCreation.Visible = false;
            this.pn_HeroCreation.VisibleChanged += new System.EventHandler(this.CreationShow);
            // 
            // btn_HeroLabel
            // 
            this.btn_HeroLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_HeroLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HeroLabel.Location = new System.Drawing.Point(3, 4);
            this.btn_HeroLabel.Name = "btn_HeroLabel";
            this.btn_HeroLabel.Size = new System.Drawing.Size(618, 42);
            this.btn_HeroLabel.TabIndex = 14;
            this.btn_HeroLabel.Text = "Overview";
            this.btn_HeroLabel.UseVisualStyleBackColor = false;
            // 
            // btn_CreateHero
            // 
            this.btn_CreateHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_CreateHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateHero.Location = new System.Drawing.Point(415, 264);
            this.btn_CreateHero.Name = "btn_CreateHero";
            this.btn_CreateHero.Size = new System.Drawing.Size(206, 100);
            this.btn_CreateHero.TabIndex = 13;
            this.btn_CreateHero.Text = "Create Hero";
            this.btn_CreateHero.UseVisualStyleBackColor = false;
            this.btn_CreateHero.Click += new System.EventHandler(this.CreateHeroButton);
            // 
            // btn_SuitColorCreation
            // 
            this.btn_SuitColorCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btn_SuitColorCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuitColorCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuitColorCreation.Location = new System.Drawing.Point(415, 158);
            this.btn_SuitColorCreation.Name = "btn_SuitColorCreation";
            this.btn_SuitColorCreation.Size = new System.Drawing.Size(206, 100);
            this.btn_SuitColorCreation.TabIndex = 12;
            this.btn_SuitColorCreation.Text = "Suit Color";
            this.btn_SuitColorCreation.UseVisualStyleBackColor = false;
            // 
            // btn_CapeColorCreation
            // 
            this.btn_CapeColorCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btn_CapeColorCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapeColorCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapeColorCreation.Location = new System.Drawing.Point(521, 52);
            this.btn_CapeColorCreation.Name = "btn_CapeColorCreation";
            this.btn_CapeColorCreation.Size = new System.Drawing.Size(100, 100);
            this.btn_CapeColorCreation.TabIndex = 11;
            this.btn_CapeColorCreation.Text = "Cape color";
            this.btn_CapeColorCreation.UseVisualStyleBackColor = false;
            // 
            // btn_MaskColorCreation
            // 
            this.btn_MaskColorCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btn_MaskColorCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaskColorCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaskColorCreation.Location = new System.Drawing.Point(415, 52);
            this.btn_MaskColorCreation.Name = "btn_MaskColorCreation";
            this.btn_MaskColorCreation.Size = new System.Drawing.Size(100, 100);
            this.btn_MaskColorCreation.TabIndex = 10;
            this.btn_MaskColorCreation.Text = "Mask Color";
            this.btn_MaskColorCreation.UseVisualStyleBackColor = false;
            // 
            // LiB_Offices
            // 
            this.LiB_Offices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.LiB_Offices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LiB_Offices.FormattingEnabled = true;
            this.LiB_Offices.ItemHeight = 16;
            this.LiB_Offices.Location = new System.Drawing.Point(209, 52);
            this.LiB_Offices.Name = "LiB_Offices";
            this.LiB_Offices.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LiB_Offices.Size = new System.Drawing.Size(200, 100);
            this.LiB_Offices.TabIndex = 4;
            // 
            // LiB_Statistics
            // 
            this.LiB_Statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.LiB_Statistics.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LiB_Statistics.FormattingEnabled = true;
            this.LiB_Statistics.ItemHeight = 16;
            this.LiB_Statistics.Location = new System.Drawing.Point(3, 264);
            this.LiB_Statistics.Name = "LiB_Statistics";
            this.LiB_Statistics.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LiB_Statistics.Size = new System.Drawing.Size(200, 100);
            this.LiB_Statistics.TabIndex = 3;
            // 
            // LiB_Dates
            // 
            this.LiB_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.LiB_Dates.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LiB_Dates.FormattingEnabled = true;
            this.LiB_Dates.ItemHeight = 16;
            this.LiB_Dates.Location = new System.Drawing.Point(3, 158);
            this.LiB_Dates.Name = "LiB_Dates";
            this.LiB_Dates.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LiB_Dates.Size = new System.Drawing.Size(200, 100);
            this.LiB_Dates.TabIndex = 2;
            // 
            // LiB_SuperPowers
            // 
            this.LiB_SuperPowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.LiB_SuperPowers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LiB_SuperPowers.FormattingEnabled = true;
            this.LiB_SuperPowers.ItemHeight = 16;
            this.LiB_SuperPowers.Location = new System.Drawing.Point(3, 52);
            this.LiB_SuperPowers.Name = "LiB_SuperPowers";
            this.LiB_SuperPowers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LiB_SuperPowers.Size = new System.Drawing.Size(200, 100);
            this.LiB_SuperPowers.TabIndex = 0;
            // 
            // pn_navigation
            // 
            this.pn_navigation.Location = new System.Drawing.Point(1796, 515);
            this.pn_navigation.Name = "pn_navigation";
            this.pn_navigation.Size = new System.Drawing.Size(125, 80);
            this.pn_navigation.TabIndex = 16;
            // 
            // PiB_ProfileHeroCreation
            // 
            this.PiB_ProfileHeroCreation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PiB_ProfileHeroCreation.Location = new System.Drawing.Point(209, 158);
            this.PiB_ProfileHeroCreation.Name = "PiB_ProfileHeroCreation";
            this.PiB_ProfileHeroCreation.Size = new System.Drawing.Size(200, 200);
            this.PiB_ProfileHeroCreation.TabIndex = 10;
            this.PiB_ProfileHeroCreation.TabStop = false;
            // 
            // piB_Profile
            // 
            this.piB_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piB_Profile.Location = new System.Drawing.Point(120, 215);
            this.piB_Profile.Name = "piB_Profile";
            this.piB_Profile.Size = new System.Drawing.Size(150, 150);
            this.piB_Profile.TabIndex = 9;
            this.piB_Profile.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = global::Ea2_Activity4.Properties.Resources.Back;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 30);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Main Menu";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // piB_Hair
            // 
            this.piB_Hair.BackColor = System.Drawing.Color.Transparent;
            this.piB_Hair.Location = new System.Drawing.Point(120, 227);
            this.piB_Hair.Name = "piB_Hair";
            this.piB_Hair.Size = new System.Drawing.Size(150, 137);
            this.piB_Hair.TabIndex = 6;
            this.piB_Hair.TabStop = false;
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1951, 836);
            this.Controls.Add(this.pn_navigation);
            this.Controls.Add(this.pn_HeroCreation);
            this.Controls.Add(this.pn_Aesthetic);
            this.Controls.Add(this.pn_Stats);
            this.Controls.Add(this.pn_Dates);
            this.Controls.Add(this.pn_cities);
            this.Controls.Add(this.hsb_pages);
            this.Controls.Add(this.pn_Abilities);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_HeroName);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Basic";
            this.ShowIcon = false;
            this.Text = " Hero Creation";
            this.pn_Abilities.ResumeLayout(false);
            this.pn_Abilities.PerformLayout();
            this.pn_cities.ResumeLayout(false);
            this.pn_cities.PerformLayout();
            this.pn_Dates.ResumeLayout(false);
            this.pn_Dates.PerformLayout();
            this.pn_Stats.ResumeLayout(false);
            this.pn_Stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trB_DarkSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Vitality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Vitality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Dexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Strength)).EndInit();
            this.pn_Aesthetic.ResumeLayout(false);
            this.pn_Aesthetic.PerformLayout();
            this.pn_HeroCreation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PiB_ProfileHeroCreation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Hair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_HeroName;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox gb_Abilities;
        private System.Windows.Forms.Panel pn_Abilities;
        private System.Windows.Forms.HScrollBar hsb_pages;
        private System.Windows.Forms.Panel pn_cities;
        private System.Windows.Forms.ListBox lb_Cities;
        private System.Windows.Forms.Label lb_OfficeLocations;
        private System.Windows.Forms.Panel pn_Dates;
        private System.Windows.Forms.Label lb_ImpDates;
        private System.Windows.Forms.RadioButton RB_ReDD;
        private System.Windows.Forms.RadioButton RB_Retirement;
        private System.Windows.Forms.RadioButton RB_Active;
        private System.Windows.Forms.Label lb_Grad;
        private System.Windows.Forms.DateTimePicker DTP_Grad;
        private System.Windows.Forms.Label lb_Birthday;
        private System.Windows.Forms.DateTimePicker DTP_Bday;
        private System.Windows.Forms.Label lb_reDD;
        private System.Windows.Forms.DateTimePicker DTP_ReDD;
        private System.Windows.Forms.Panel pn_Stats;
        private System.Windows.Forms.TrackBar trb_Strength;
        private System.Windows.Forms.NumericUpDown nud_Strength;
        private System.Windows.Forms.NumericUpDown nud_Vitality;
        private System.Windows.Forms.NumericUpDown nud_Dexterity;
        private System.Windows.Forms.TrackBar trb_Vitality;
        private System.Windows.Forms.TrackBar trb_Dexterity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Vitality;
        private System.Windows.Forms.Label lb_Dexterity;
        private System.Windows.Forms.Label lb_Strength;
        private System.Windows.Forms.Label lb_Darkside;
        private System.Windows.Forms.TrackBar trB_DarkSide;
        private System.Windows.Forms.Panel pn_Aesthetic;
        private System.Windows.Forms.Button btn_CapeColor;
        private System.Windows.Forms.Label lb_Aesthetics;
        private System.Windows.Forms.GroupBox gB_Pictures;
        private System.Windows.Forms.PictureBox piB_Hair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_MaskColor;
        private System.Windows.Forms.Button btn_SuitColor;
        private System.Windows.Forms.PictureBox piB_Profile;
        private System.Windows.Forms.Panel pn_HeroCreation;
        private System.Windows.Forms.Button btn_HeroLabel;
        private System.Windows.Forms.Button btn_CreateHero;
        private System.Windows.Forms.Button btn_SuitColorCreation;
        private System.Windows.Forms.Button btn_CapeColorCreation;
        private System.Windows.Forms.Button btn_MaskColorCreation;
        private System.Windows.Forms.PictureBox PiB_ProfileHeroCreation;
        private System.Windows.Forms.ListBox LiB_Offices;
        private System.Windows.Forms.ListBox LiB_Statistics;
        private System.Windows.Forms.ListBox LiB_Dates;
        private System.Windows.Forms.ListBox LiB_SuperPowers;
        private System.Windows.Forms.Panel pn_navigation;
        private System.Windows.Forms.TextBox tb_hint;
    }
}