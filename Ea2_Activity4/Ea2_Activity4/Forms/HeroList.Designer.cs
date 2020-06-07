namespace Ea2_Activity4.Forms
{
    partial class HeroList
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
            this.lb_HeroList = new System.Windows.Forms.ListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_HeroList
            // 
            this.lb_HeroList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.lb_HeroList.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_HeroList.FormattingEnabled = true;
            this.lb_HeroList.ItemHeight = 16;
            this.lb_HeroList.Location = new System.Drawing.Point(13, 45);
            this.lb_HeroList.Name = "lb_HeroList";
            this.lb_HeroList.Size = new System.Drawing.Size(295, 372);
            this.lb_HeroList.TabIndex = 0;
            this.lb_HeroList.SelectedIndexChanged += new System.EventHandler(this.SelectHero);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Image = global::Ea2_Activity4.Properties.Resources.Back;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(13, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 30);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Main Menu";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // HeroList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(325, 426);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_HeroList);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "HeroList";
            this.ShowIcon = false;
            this.Text = "Hero List";
            this.Activated += new System.EventHandler(this.UpdateSystem);
            this.Load += new System.EventHandler(this.UpdateSystem);
            this.Click += new System.EventHandler(this.UpdateSystem);
            this.Enter += new System.EventHandler(this.UpdateSystem);
            this.Leave += new System.EventHandler(this.UpdateSystem);
            this.MouseHover += new System.EventHandler(this.UpdateSystem);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox lb_HeroList;
    }
}