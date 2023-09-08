namespace Kyrsova
{
    partial class Zamok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamok));
            this.pZamok = new System.Windows.Forms.PictureBox();
            this.btDown1 = new System.Windows.Forms.Button();
            this.btDown2 = new System.Windows.Forms.Button();
            this.btDown3 = new System.Windows.Forms.Button();
            this.btUp1 = new System.Windows.Forms.Button();
            this.btUp3 = new System.Windows.Forms.Button();
            this.btUp2 = new System.Windows.Forms.Button();
            this.Lb3 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.btChek = new System.Windows.Forms.Button();
            this.PrintBonus = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pZamok)).BeginInit();
            this.SuspendLayout();
            // 
            // pZamok
            // 
            this.pZamok.Image = ((System.Drawing.Image)(resources.GetObject("pZamok.Image")));
            this.pZamok.Location = new System.Drawing.Point(48, -2);
            this.pZamok.Name = "pZamok";
            this.pZamok.Size = new System.Drawing.Size(758, 565);
            this.pZamok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pZamok.TabIndex = 0;
            this.pZamok.TabStop = false;
            // 
            // btDown1
            // 
            this.btDown1.Image = global::Kyrsova.Properties.Resources.Down;
            this.btDown1.Location = new System.Drawing.Point(473, 255);
            this.btDown1.Name = "btDown1";
            this.btDown1.Size = new System.Drawing.Size(74, 65);
            this.btDown1.TabIndex = 1;
            this.btDown1.Text = "V";
            this.btDown1.UseVisualStyleBackColor = true;
            this.btDown1.Click += new System.EventHandler(this.btDown1_Click);
            // 
            // btDown2
            // 
            this.btDown2.Image = global::Kyrsova.Properties.Resources.Down;
            this.btDown2.Location = new System.Drawing.Point(366, 255);
            this.btDown2.Name = "btDown2";
            this.btDown2.Size = new System.Drawing.Size(74, 65);
            this.btDown2.TabIndex = 2;
            this.btDown2.Text = "V";
            this.btDown2.UseVisualStyleBackColor = true;
            this.btDown2.Click += new System.EventHandler(this.btDown2_Click);
            // 
            // btDown3
            // 
            this.btDown3.Image = global::Kyrsova.Properties.Resources.Down;
            this.btDown3.Location = new System.Drawing.Point(250, 255);
            this.btDown3.Name = "btDown3";
            this.btDown3.Size = new System.Drawing.Size(74, 65);
            this.btDown3.TabIndex = 3;
            this.btDown3.Text = "V";
            this.btDown3.UseVisualStyleBackColor = true;
            this.btDown3.Click += new System.EventHandler(this.btDown3_Click);
            // 
            // btUp1
            // 
            this.btUp1.Image = global::Kyrsova.Properties.Resources.Up;
            this.btUp1.Location = new System.Drawing.Point(448, 39);
            this.btUp1.Name = "btUp1";
            this.btUp1.Size = new System.Drawing.Size(74, 65);
            this.btUp1.TabIndex = 4;
            this.btUp1.Text = "/\\";
            this.btUp1.UseVisualStyleBackColor = true;
            this.btUp1.Click += new System.EventHandler(this.btUp1_Click);
            // 
            // btUp3
            // 
            this.btUp3.Image = global::Kyrsova.Properties.Resources.Up;
            this.btUp3.Location = new System.Drawing.Point(280, 39);
            this.btUp3.Name = "btUp3";
            this.btUp3.Size = new System.Drawing.Size(74, 65);
            this.btUp3.TabIndex = 5;
            this.btUp3.Text = "/\\";
            this.btUp3.UseVisualStyleBackColor = true;
            this.btUp3.Click += new System.EventHandler(this.btUp3_Click);
            // 
            // btUp2
            // 
            this.btUp2.Image = global::Kyrsova.Properties.Resources.Up;
            this.btUp2.Location = new System.Drawing.Point(364, 39);
            this.btUp2.Name = "btUp2";
            this.btUp2.Size = new System.Drawing.Size(74, 65);
            this.btUp2.TabIndex = 6;
            this.btUp2.Text = "/\\";
            this.btUp2.UseVisualStyleBackColor = true;
            this.btUp2.Click += new System.EventHandler(this.btUp2_Click);
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb3.Location = new System.Drawing.Point(483, 155);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(42, 46);
            this.Lb3.TabIndex = 8;
            this.Lb3.Text = "0";
            this.Lb3.TextChanged += new System.EventHandler(this.Lb3_TextChanged);
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb2.Location = new System.Drawing.Point(378, 155);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(42, 46);
            this.Lb2.TabIndex = 9;
            this.Lb2.Text = "0";
            this.Lb2.TextChanged += new System.EventHandler(this.Lb3_TextChanged);
            this.Lb2.Click += new System.EventHandler(this.Lb2_Click);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb1.Location = new System.Drawing.Point(275, 155);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(42, 46);
            this.Lb1.TabIndex = 10;
            this.Lb1.Text = "0";
            this.Lb1.TextChanged += new System.EventHandler(this.Lb3_TextChanged);
            // 
            // btChek
            // 
            this.btChek.Location = new System.Drawing.Point(366, 360);
            this.btChek.Name = "btChek";
            this.btChek.Size = new System.Drawing.Size(74, 32);
            this.btChek.TabIndex = 11;
            this.btChek.Text = "Chek";
            this.btChek.UseVisualStyleBackColor = true;
            this.btChek.Click += new System.EventHandler(this.btChek_Click);
            // 
            // PrintBonus
            // 
            this.PrintBonus.Location = new System.Drawing.Point(115, 48);
            this.PrintBonus.Name = "PrintBonus";
            this.PrintBonus.Size = new System.Drawing.Size(100, 22);
            this.PrintBonus.TabIndex = 12;
            this.PrintBonus.TextChanged += new System.EventHandler(this.PrintBonus_TextChanged);
            // 
            // Refresh
            // 
            this.Refresh.Enabled = false;
            this.Refresh.Location = new System.Drawing.Point(126, 76);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 13;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Рахунок:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Zamok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kyrsova.Properties.Resources.Fon_level_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.PrintBonus);
            this.Controls.Add(this.btChek);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.Lb3);
            this.Controls.Add(this.btUp2);
            this.Controls.Add(this.btUp3);
            this.Controls.Add(this.btUp1);
            this.Controls.Add(this.btDown3);
            this.Controls.Add(this.btDown2);
            this.Controls.Add(this.btDown1);
            this.Controls.Add(this.pZamok);
            this.Name = "Zamok";
            this.Text = "Zamok";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Zamok_FormClosed);
            this.Load += new System.EventHandler(this.Zamok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pZamok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pZamok;
        private System.Windows.Forms.Button btDown1;
        private System.Windows.Forms.Button btDown2;
        private System.Windows.Forms.Button btDown3;
        private System.Windows.Forms.Button btUp1;
        private System.Windows.Forms.Button btUp3;
        private System.Windows.Forms.Button btUp2;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Button btChek;
        private System.Windows.Forms.TextBox PrintBonus;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
    }
}