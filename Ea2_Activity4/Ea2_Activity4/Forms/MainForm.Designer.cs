namespace Ea2_Activity4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.btn_custom = new System.Windows.Forms.Button();
            this.btn_basic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Hero Main Menu";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Chicago.jpg");
            this.ImageList.Images.SetKeyName(1, "HongKong.jpg");
            this.ImageList.Images.SetKeyName(2, "London.jpg");
            this.ImageList.Images.SetKeyName(3, "LosAngeles.jpg");
            this.ImageList.Images.SetKeyName(4, "NewYork.jpg");
            this.ImageList.Images.SetKeyName(5, "Paris.jpg");
            this.ImageList.Images.SetKeyName(6, "Philippines.jpg");
            this.ImageList.Images.SetKeyName(7, "Rome.jpg");
            this.ImageList.Images.SetKeyName(8, "SanFransisco.jpg");
            this.ImageList.Images.SetKeyName(9, "Seoul.jpg");
            this.ImageList.Images.SetKeyName(10, "Shanghai.jpg");
            this.ImageList.Images.SetKeyName(11, "Syndey.jpg");
            this.ImageList.Images.SetKeyName(12, "Washington.jpg");
            // 
            // btn_custom
            // 
            this.btn_custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_custom.FlatAppearance.BorderSize = 0;
            this.btn_custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custom.Image = global::Ea2_Activity4.Properties.Resources.Group;
            this.btn_custom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_custom.Location = new System.Drawing.Point(268, 67);
            this.btn_custom.Name = "btn_custom";
            this.btn_custom.Size = new System.Drawing.Size(150, 40);
            this.btn_custom.TabIndex = 2;
            this.btn_custom.Text = "Hero List";
            this.btn_custom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_custom.UseVisualStyleBackColor = false;
            this.btn_custom.Click += new System.EventHandler(this.beepbeep);
            // 
            // btn_basic
            // 
            this.btn_basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btn_basic.FlatAppearance.BorderSize = 0;
            this.btn_basic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basic.Image = global::Ea2_Activity4.Properties.Resources.Add;
            this.btn_basic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_basic.Location = new System.Drawing.Point(43, 67);
            this.btn_basic.Name = "btn_basic";
            this.btn_basic.Size = new System.Drawing.Size(170, 40);
            this.btn_basic.TabIndex = 1;
            this.btn_basic.Text = "Hero Creation";
            this.btn_basic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_basic.UseVisualStyleBackColor = false;
            this.btn_basic.Click += new System.EventHandler(this.beepbeep);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(473, 120);
            this.Controls.Add(this.btn_custom);
            this.Controls.Add(this.btn_basic);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button btn_basic;
        private System.Windows.Forms.Button btn_custom;
    }
}

