namespace Kyrsova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btZamok = new System.Windows.Forms.Button();
            this.btOclock = new System.Windows.Forms.Button();
            this.btPomogator1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btZamok
            // 
            this.btZamok.BackgroundImage = global::Kyrsova.Properties.Resources.Без_имени_21;
            this.btZamok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btZamok.Location = new System.Drawing.Point(349, 371);
            this.btZamok.Name = "btZamok";
            this.btZamok.Size = new System.Drawing.Size(97, 37);
            this.btZamok.TabIndex = 0;
            this.btZamok.UseVisualStyleBackColor = true;
            this.btZamok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOclock
            // 
            this.btOclock.BackgroundImage = global::Kyrsova.Properties.Resources.Без_имени_31;
            this.btOclock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOclock.Location = new System.Drawing.Point(517, 370);
            this.btOclock.Name = "btOclock";
            this.btOclock.Size = new System.Drawing.Size(97, 37);
            this.btOclock.TabIndex = 1;
            this.btOclock.UseVisualStyleBackColor = true;
            this.btOclock.Click += new System.EventHandler(this.btLevel3_Click);
            // 
            // btPomogator1
            // 
            this.btPomogator1.BackgroundImage = global::Kyrsova.Properties.Resources.Без_имени_13;
            this.btPomogator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPomogator1.Location = new System.Drawing.Point(184, 371);
            this.btPomogator1.Name = "btPomogator1";
            this.btPomogator1.Size = new System.Drawing.Size(97, 37);
            this.btPomogator1.TabIndex = 2;
            this.btPomogator1.UseVisualStyleBackColor = true;
            this.btPomogator1.Click += new System.EventHandler(this.btPomogator1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kyrsova.Properties.Resources.fiksiki_fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btPomogator1);
            this.Controls.Add(this.btOclock);
            this.Controls.Add(this.btZamok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btZamok;
        private System.Windows.Forms.Button btOclock;
        private System.Windows.Forms.Button btPomogator1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

