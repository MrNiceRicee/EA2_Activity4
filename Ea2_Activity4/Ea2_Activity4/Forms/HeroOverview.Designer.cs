namespace Ea2_Activity4.Forms
{
    partial class HeroOverview
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
            this.pn_HeroCreation = new System.Windows.Forms.Panel();
            this.btn_HeroLabel = new System.Windows.Forms.Button();
            this.btn_SuitColorCreation = new System.Windows.Forms.Button();
            this.btn_CapeColorCreation = new System.Windows.Forms.Button();
            this.btn_MaskColorCreation = new System.Windows.Forms.Button();
            this.LiB_Offices = new System.Windows.Forms.ListBox();
            this.LiB_Statistics = new System.Windows.Forms.ListBox();
            this.LiB_Dates = new System.Windows.Forms.ListBox();
            this.LiB_SuperPowers = new System.Windows.Forms.ListBox();
            this.PiB_ProfileHeroCreation = new System.Windows.Forms.PictureBox();
            this.pn_HeroCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiB_ProfileHeroCreation)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_HeroCreation
            // 
            this.pn_HeroCreation.Controls.Add(this.btn_HeroLabel);
            this.pn_HeroCreation.Controls.Add(this.btn_SuitColorCreation);
            this.pn_HeroCreation.Controls.Add(this.btn_CapeColorCreation);
            this.pn_HeroCreation.Controls.Add(this.btn_MaskColorCreation);
            this.pn_HeroCreation.Controls.Add(this.PiB_ProfileHeroCreation);
            this.pn_HeroCreation.Controls.Add(this.LiB_Offices);
            this.pn_HeroCreation.Controls.Add(this.LiB_Statistics);
            this.pn_HeroCreation.Controls.Add(this.LiB_Dates);
            this.pn_HeroCreation.Controls.Add(this.LiB_SuperPowers);
            this.pn_HeroCreation.Location = new System.Drawing.Point(12, 12);
            this.pn_HeroCreation.Name = "pn_HeroCreation";
            this.pn_HeroCreation.Size = new System.Drawing.Size(626, 368);
            this.pn_HeroCreation.TabIndex = 17;
            this.pn_HeroCreation.Tag = "Overview";
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
            // PiB_ProfileHeroCreation
            // 
            this.PiB_ProfileHeroCreation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PiB_ProfileHeroCreation.Location = new System.Drawing.Point(209, 158);
            this.PiB_ProfileHeroCreation.Name = "PiB_ProfileHeroCreation";
            this.PiB_ProfileHeroCreation.Size = new System.Drawing.Size(200, 200);
            this.PiB_ProfileHeroCreation.TabIndex = 10;
            this.PiB_ProfileHeroCreation.TabStop = false;
            // 
            // HeroOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(652, 397);
            this.Controls.Add(this.pn_HeroCreation);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "HeroOverview";
            this.ShowIcon = false;
            this.Text = "Hero Overview";
            this.pn_HeroCreation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PiB_ProfileHeroCreation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_HeroCreation;
        private System.Windows.Forms.Button btn_HeroLabel;
        private System.Windows.Forms.Button btn_SuitColorCreation;
        private System.Windows.Forms.Button btn_CapeColorCreation;
        private System.Windows.Forms.Button btn_MaskColorCreation;
        private System.Windows.Forms.PictureBox PiB_ProfileHeroCreation;
        private System.Windows.Forms.ListBox LiB_Offices;
        private System.Windows.Forms.ListBox LiB_Statistics;
        private System.Windows.Forms.ListBox LiB_Dates;
        private System.Windows.Forms.ListBox LiB_SuperPowers;
    }
}