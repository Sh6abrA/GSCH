
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
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Генерация случайного числа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Diapazon_1
            // 
            this.Diapazon_1.Location = new System.Drawing.Point(12, 23);
            this.Diapazon_1.Name = "Diapazon_1";
            this.Diapazon_1.Size = new System.Drawing.Size(120, 23);
            this.Diapazon_1.TabIndex = 1;
            // 
            // Diapazon_2
            // 
            this.Diapazon_2.Location = new System.Drawing.Point(220, 23);
            this.Diapazon_2.Name = "Diapazon_2";
            this.Diapazon_2.Size = new System.Drawing.Size(120, 23);
            this.Diapazon_2.TabIndex = 2;
            // 
            // Vivod
            // 
            this.Vivod.Location = new System.Drawing.Point(12, 263);
            this.Vivod.Multiline = true;
            this.Vivod.Name = "Vivod";
            this.Vivod.Size = new System.Drawing.Size(338, 118);
            this.Vivod.TabIndex = 4;
            // 
            // Oracul
            // 
            this.Oracul.Location = new System.Drawing.Point(522, 91);
            this.Oracul.Name = "Oracul";
            this.Oracul.Size = new System.Drawing.Size(194, 90);
            this.Oracul.TabIndex = 5;
            this.Oracul.Text = "Жак Фреско";
            this.Oracul.UseVisualStyleBackColor = true;
            this.Oracul.Click += new System.EventHandler(this.Oracul_Click);
            // 
            // Vvod
            // 
            this.Vvod.Location = new System.Drawing.Point(441, 263);
            this.Vvod.Multiline = true;
            this.Vvod.Name = "Vvod";
            this.Vvod.Size = new System.Drawing.Size(312, 118);
            this.Vvod.TabIndex = 6;
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(323, 90);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(146, 90);
            this.Crypt.TabIndex = 7;
            this.Crypt.Text = "Crypt";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(323, 186);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(146, 60);
            this.Decrypt.TabIndex = 8;
            this.Decrypt.Text = "Расшифровка";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.Vvod);
            this.Controls.Add(this.Oracul);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Diapazon_2);
            this.Controls.Add(this.Diapazon_1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diapazon_2)).EndInit();
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
    }
}

