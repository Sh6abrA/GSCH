
namespace GSCH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Diapazon_1 = new System.Windows.Forms.NumericUpDown();
            this.Diapazon_2 = new System.Windows.Forms.NumericUpDown();
            this.Vivod = new System.Windows.Forms.TextBox();
            this.Oracul = new System.Windows.Forms.Button();
            this.Vvod = new System.Windows.Forms.TextBox();
            this.Crypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Paint = new System.Windows.Forms.Button();
            this.Drawer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Генерация случайного числа";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Diapazon_1
            // 
            this.Diapazon_1.BackColor = System.Drawing.Color.Silver;
            this.Diapazon_1.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Diapazon_1.Location = new System.Drawing.Point(12, 23);
            this.Diapazon_1.Name = "Diapazon_1";
            this.Diapazon_1.Size = new System.Drawing.Size(120, 23);
            this.Diapazon_1.TabIndex = 1;
            // 
            // Diapazon_2
            // 
            this.Diapazon_2.BackColor = System.Drawing.Color.Silver;
            this.Diapazon_2.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Diapazon_2.ForeColor = System.Drawing.Color.Black;
            this.Diapazon_2.Location = new System.Drawing.Point(220, 23);
            this.Diapazon_2.Name = "Diapazon_2";
            this.Diapazon_2.Size = new System.Drawing.Size(120, 23);
            this.Diapazon_2.TabIndex = 2;
            // 
            // Vivod
            // 
            this.Vivod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Vivod.Cursor = System.Windows.Forms.Cursors.Default;
            this.Vivod.Font = new System.Drawing.Font("EagleSans-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vivod.ForeColor = System.Drawing.Color.White;
            this.Vivod.Location = new System.Drawing.Point(12, 314);
            this.Vivod.Multiline = true;
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(357, 208);
            this.Vivod.TabIndex = 4;
            // 
            // Oracul
            // 
            this.Oracul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Oracul.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Oracul.ForeColor = System.Drawing.Color.Black;
            this.Oracul.Image = global::GSCH.Properties.Resources.back_2;
            this.Oracul.Location = new System.Drawing.Point(522, 91);
            this.Oracul.Name = "Oracul";
            this.Oracul.Size = new System.Drawing.Size(194, 90);
            this.Oracul.TabIndex = 5;
            this.Oracul.UseVisualStyleBackColor = true;
            this.Oracul.Click += new System.EventHandler(this.Oracul_Click);
            // 
            // Vvod
            // 
            this.Vvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Vvod.Cursor = System.Windows.Forms.Cursors.Default;
            this.Vvod.Font = new System.Drawing.Font("EagleSans-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vvod.ForeColor = System.Drawing.Color.White;
            this.Vvod.Location = new System.Drawing.Point(442, 314);
            this.Vvod.Multiline = true;
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(344, 208);
            this.Vvod.TabIndex = 6;
            // 
            // Crypt
            // 
            this.Crypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Crypt.BackgroundImage = global::GSCH.Properties.Resources.back_4;
            this.Crypt.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Crypt.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Crypt.ForeColor = System.Drawing.Color.Black;
            this.Crypt.Image = global::GSCH.Properties.Resources.back_4;
            this.Crypt.Location = new System.Drawing.Point(323, 90);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(146, 90);
            this.Crypt.TabIndex = 7;
            this.Crypt.UseVisualStyleBackColor = false;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Decrypt.Image = global::GSCH.Properties.Resources.back_3;
            this.Decrypt.Location = new System.Drawing.Point(323, 197);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(146, 60);
            this.Decrypt.TabIndex = 8;
            this.Decrypt.Text = "Расшифровка";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Picture.Location = new System.Drawing.Point(892, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(818, 806);
            this.Picture.TabIndex = 9;
            this.Picture.TabStop = false;
            // 
            // Paint
            // 
            this.Paint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Paint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paint.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Paint.ForeColor = System.Drawing.Color.White;
            this.Paint.Location = new System.Drawing.Point(150, 633);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(151, 60);
            this.Paint.TabIndex = 10;
            this.Paint.Text = "Draw1";
            this.Paint.UseVisualStyleBackColor = false;
            this.Paint.Click += new System.EventHandler(this.Draw);
            // 
            // Drawer
            // 
            this.Drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Drawer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drawer.Font = new System.Drawing.Font("EagleSans-Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Drawer.ForeColor = System.Drawing.Color.White;
            this.Drawer.Location = new System.Drawing.Point(478, 633);
            this.Drawer.Name = "Drawer";
            this.Drawer.Size = new System.Drawing.Size(162, 60);
            this.Drawer.TabIndex = 11;
            this.Drawer.Text = "Draw2";
            this.Drawer.UseVisualStyleBackColor = false;
            this.Drawer.Click += new System.EventHandler(this.Drawer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSCH.Properties.Resources.back_1;
            this.ClientSize = new System.Drawing.Size(1753, 851);
            this.Controls.Add(this.Drawer);
            this.Controls.Add(this.Paint);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Oracul);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Diapazon_2);
            this.Controls.Add(this.Diapazon_1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Random";
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Diapazon_1;
        private System.Windows.Forms.NumericUpDown Diapazon_2;
        private System.Windows.Forms.TextBox Vivod;
        private System.Windows.Forms.Button Oracul;
        private System.Windows.Forms.TextBox Vvod;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Button Drawer;
    }
}

