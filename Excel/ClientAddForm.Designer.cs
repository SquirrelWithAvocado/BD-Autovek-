using System.ComponentModel; 
using System.Drawing;
 
namespace Excel.App 
{ 
    partial class ClientAddForm 
    { 
        /// <summary> 
        /// Required designer variable. 
        /// </summary> 
        private IContainer components = null; 
 
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
            this.Icon = new Icon(@"img\Group-1.ico");

            this.MaximizeBox = false;

            this.panel1 = new System.Windows.Forms.Panel(); 
            this.label2 = new System.Windows.Forms.Label(); 
            this.label1 = new System.Windows.Forms.Label(); 
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); 
            this.label3 = new System.Windows.Forms.Label(); 
            this.label4 = new System.Windows.Forms.Label(); 
            this.label5 = new System.Windows.Forms.Label(); 
            this.label6 = new System.Windows.Forms.Label(); 
            this.label7 = new System.Windows.Forms.Label(); 
            this.button1 = new System.Windows.Forms.Button(); 
            this.textBox1 = new System.Windows.Forms.TextBox(); 
            this.textBox2 = new System.Windows.Forms.TextBox(); 
            this.textBox3 = new System.Windows.Forms.TextBox(); 
            this.textBox4 = new System.Windows.Forms.TextBox(); 
            this.textBox5 = new System.Windows.Forms.TextBox(); 
            this.textBox6 = new System.Windows.Forms.TextBox(); 
            this.label8 = new System.Windows.Forms.Label(); 
            this.label9 = new System.Windows.Forms.Label(); 
            this.textBox7 = new System.Windows.Forms.TextBox(); 
            this.label10 = new System.Windows.Forms.Label(); 
            this.label11 = new System.Windows.Forms.Label(); 
            this.textBox8 = new System.Windows.Forms.TextBox(); 
            this.label12 = new System.Windows.Forms.Label(); 
            this.textBox9 = new System.Windows.Forms.TextBox(); 
            this.panel1.SuspendLayout(); 
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit(); 
            this.SuspendLayout(); 
            //  
            // panel1 
            //  
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight; 
            this.panel1.Controls.Add(this.label2); 
            this.panel1.Controls.Add(this.label1); 
            this.panel1.Controls.Add(this.pictureBox1); 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top; 
            this.panel1.Location = new System.Drawing.Point(0, 0); 
            this.panel1.Name = "panel1"; 
            this.panel1.Size = new System.Drawing.Size(700, 52); 
            this.panel1.TabIndex = 3; 
            //  
            // label2 
            //  
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label2.Location = new System.Drawing.Point(615, 17); 
            this.label2.Name = "label2"; 
            this.label2.Size = new System.Drawing.Size(74, 22); 
            this.label2.TabIndex = 2; 
            this.label2.Text = "Выйти"; 
            this.label2.ForeColor=Color.Red;

            this.label2.Click += new System.EventHandler(this.label2_Click); 
            //  
            // label1 
            //  
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label1.Location = new System.Drawing.Point(56, 17); 
            this.label1.Name = "llabel1";
this.label1.Size = new System.Drawing.Size(88, 22); 
            this.label1.TabIndex = 1; 
            this.label1.Text = "Иванов И. И"; 
            //  
            // pictureBox1 
            //  
            this.pictureBox1.Location = new System.Drawing.Point(0, 0); 
            this.pictureBox1.Name = "pictureBox1"; 
            this.pictureBox1.Size = new System.Drawing.Size(88, 47); 
            this.pictureBox1.TabIndex = 3; 
            this.pictureBox1.TabStop = false; 
            //  
            // label3 
            //  
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label3.Location = new System.Drawing.Point(158, 90); 
            this.label3.Name = "label3"; 
            this.label3.Size = new System.Drawing.Size(88, 23); 
            this.label3.TabIndex = 4; 
            this.label3.Text = "ФИО"; 
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // label4 
            //  
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label4.Location = new System.Drawing.Point(158, 123); 
            this.label4.Name = "label4"; 
            this.label4.Size = new System.Drawing.Size(120, 23); 
            this.label4.TabIndex = 5; 
            this.label4.Text = "Дата рождения"; 
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // label5 
            //  
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label5.Location = new System.Drawing.Point(158, 156); 
            this.label5.Name = "label5"; 
            this.label5.Size = new System.Drawing.Size(136, 23); 
            this.label5.TabIndex = 6; 
            this.label5.Text = "Серия паспорта"; 
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // label6 
            //  
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label6.Location = new System.Drawing.Point(158, 222); 
            this.label6.Name = "label6"; 
            this.label6.Size = new System.Drawing.Size(88, 23); 
            this.label6.TabIndex = 7; 
            this.label6.Text = "Кем выдан"; 
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // label7 
            //  
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label7.Location = new System.Drawing.Point(158, 189); 
            this.label7.Name = "label7"; 
            this.label7.Size = new System.Drawing.Size(136, 23); 
            this.label7.TabIndex = 8; 
            this.label7.Text = "Номер паспорта"; 
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // button1 
            //  
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.button1.Location = new System.Drawing.Point(546, 338); 
            this.button1.Name = "button1"; 
            this.button1.Size = new System.Drawing.Size(102, 46); 
            this.button1.TabIndex = 9; 
            this.button1.Text = "Добавить"; 
            this.button1.UseVisualStyleBackColor = true; 
            this.button1.Click += new System.EventHandler(this.button1_Click); 
            //  
            // textBox1 
            //  
            this.textBox1.Location = new System.Drawing.Point(310, 90); 
            this.textBox1.Name = "textBox1"; 
            this.textBox1.Size = new System.Drawing.Size(205, 23); 
            this.textBox1.TabIndex = 10; 
            //  
            // textBox2 
            //  
            this.textBox2.Location = new System.Drawing.Point(310, 123); 
            this.textBox2.Name = "textBox2"; 
            this.textBox2.Size = new System.Drawing.Size(205, 23); 
            this.textBox2.TabIndex = 11; 
            //  
            // textBox3 
            //  
            this.textBox3.Location = new System.Drawing.Point(310, 156); 
            this.textBox3.Name = "textBox3"; 
            this.textBox3.Size = new System.Drawing.Size(205, 23); 
            this.textBox3.TabIndex = 12; 
            //  
            // textBox4 
            //  
            this.textBox4.Location = new System.Drawing.Point(310, 189); 
            this.textBox4.Name = "textBox4"; 
            this.textBox4.Size = new System.Drawing.Size(205, 23); 
            this.textBox4.TabIndex = 13; 
            //  
            // textBox5 
            //  
            this.textBox5.Location = new System.Drawing.Point(310, 222); 
            this.textBox5.Name = "textBox5"; 
            this.textBox5.Size = new System.Drawing.Size(205, 23); 
            this.textBox5.TabIndex = 14; 
            //  
            // textBox6 
            //  
            this.textBox6.Location = new System.Drawing.Point(310, 255); 
            this.textBox6.Name = "textBox6"; 
            this.textBox6.Size = new System.Drawing.Size(205, 23); 
            this.textBox6.TabIndex = 15; 
            //  
            // label8 
            //  
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label8.Location = new System.Drawing.Point(158, 278); 
            this.label8.Name = "label8"; 
            this.label8.Size = new System.Drawing.Size(88, 22); 
            this.label8.TabIndex = 16; 
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // label9 
            //  
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label9.Location = new System.Drawing.Point(158, 255); 
            this.label9.Name = "label9"; 
            this.label9.Size = new System.Drawing.Size(102, 23); 
            this.label9.TabIndex = 17; 
            this.label9.Text = "Дата выдачи"; 
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // textBox7 
            //  
            this.textBox7.Location = new System.Drawing.Point(310, 288); 
            this.textBox7.Name = "textBox7"; 
            this.textBox7.Size = new System.Drawing.Size(205, 23); 
            this.textBox7.TabIndex = 18; 
            //  
            // label10 
            //  
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label10.Location = new System.Drawing.Point(158, 288); 
            this.label10.Name = "label10"; 
            this.label10.Size = new System.Drawing.Size(153, 23); 
            this.label10.TabIndex = 19; 
            this.label10.Text = "Код подразделения "; 
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 

            //  
            // label11 
            //  
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label11.Location = new System.Drawing.Point(158, 321); 
            this.label11.Name = "label11"; 
            this.label11.Size = new System.Drawing.Size(146, 23); 
            this.label11.TabIndex = 20; 
            this.label11.Text = "Номер Телефона"; 
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // textBox8 
            //  
            this.textBox8.Location = new System.Drawing.Point(310, 321); 
            this.textBox8.Name = "textBox8"; 
            this.textBox8.Size = new System.Drawing.Size(205, 23); 
            this.textBox8.TabIndex = 21; 
            //  
            // label12 
            //  
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); 
            this.label12.Location = new System.Drawing.Point(158, 354); 
            this.label12.Name = "label12"; 
            this.label12.Size = new System.Drawing.Size(146, 23); 
            this.label12.TabIndex = 22; 
            this.label12.Text = "Адрес регистрации"; 
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
            //  
            // textBox9 
            //  
            this.textBox9.Location = new System.Drawing.Point(310, 354); 
            this.textBox9.Name = "textBox9"; 
            this.textBox9.Size = new System.Drawing.Size(205, 23); 
            this.textBox9.TabIndex = 23; 
            //  
            // ClientAddForm 
            //  
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))); 
            this.ClientSize = new System.Drawing.Size(700, 422); 
            this.Controls.Add(this.textBox9); 
            this.Controls.Add(this.label12); 
            this.Controls.Add(this.textBox8); 
            this.Controls.Add(this.label11); 
            this.Controls.Add(this.label10); 
            this.Controls.Add(this.textBox7); 
            this.Controls.Add(this.label9); 
            this.Controls.Add(this.label8); 
            this.Controls.Add(this.textBox6); 
            this.Controls.Add(this.textBox5); 
            this.Controls.Add(this.textBox4); 
            this.Controls.Add(this.textBox3); 
            this.Controls.Add(this.textBox2); 
            this.Controls.Add(this.textBox1); 
            this.Controls.Add(this.button1); 
            this.Controls.Add(this.label7); 
            this.Controls.Add(this.label6); 
            this.Controls.Add(this.label5); 
            this.Controls.Add(this.label4); 
            this.Controls.Add(this.label3); 
            this.Controls.Add(this.panel1); 
            this.Name = "ClientAddForm"; 
            this.Text = "-BD-Autovek-";
            this.panel1.ResumeLayout(false); 
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit(); 
            this.ResumeLayout(false); 
            this.PerformLayout(); 
 
        } 
 
        private System.Windows.Forms.Label label3; 
        private System.Windows.Forms.Label label4; 
        private System.Windows.Forms.Label label5; 
        private System.Windows.Forms.Label label6; 
        private System.Windows.Forms.Label label7; 
        private System.Windows.Forms.Button button1; 
        private System.Windows.Forms.TextBox textBox1; 
        private System.Windows.Forms.TextBox textBox2; 
        private System.Windows.Forms.TextBox textBox3; 
        private System.Windows.Forms.TextBox textBox4; 
        private System.Windows.Forms.TextBox textBox5; 
 
        private System.Windows.Forms.Panel panel1; 
        private System.Windows.Forms.Label label2; 
        private System.Windows.Forms.Label label1; 
        private System.Windows.Forms.PictureBox pictureBox1; 
 
        #endregion 
 
        private System.Windows.Forms.TextBox textBox6; 
        private System.Windows.Forms.Label label8; 
        private System.Windows.Forms.Label label9; 
        private System.Windows.Forms.TextBox textBox7; 
        private System.Windows.Forms.Label label10; 
        private System.Windows.Forms.Label label11; 
        private System.Windows.Forms.TextBox textBox8; 
        private System.Windows.Forms.Label label12; 
        private System.Windows.Forms.TextBox textBox9; 
    } 
}