namespace WindowsFormsApp1
{
    partial class ul1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSek = new System.Windows.Forms.Label();
            this.labMin = new System.Windows.Forms.Label();
            this.labTun = new System.Windows.Forms.Label();
            this.labP = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Sek = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Tun = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labSek);
            this.groupBox1.Controls.Add(this.labMin);
            this.groupBox1.Controls.Add(this.labTun);
            this.groupBox1.Controls.Add(this.labP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aeg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(302, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(205, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(108, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labSek
            // 
            this.labSek.AutoSize = true;
            this.labSek.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSek.ForeColor = System.Drawing.Color.Black;
            this.labSek.Location = new System.Drawing.Point(336, 66);
            this.labSek.Name = "labSek";
            this.labSek.Size = new System.Drawing.Size(57, 39);
            this.labSek.TabIndex = 3;
            this.labSek.Text = "00";
            this.labSek.Click += new System.EventHandler(this.labSek_Click);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMin.ForeColor = System.Drawing.Color.Black;
            this.labMin.Location = new System.Drawing.Point(239, 66);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(57, 39);
            this.labMin.TabIndex = 2;
            this.labMin.Text = "00";
            // 
            // labTun
            // 
            this.labTun.AutoSize = true;
            this.labTun.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTun.ForeColor = System.Drawing.Color.Black;
            this.labTun.Location = new System.Drawing.Point(142, 66);
            this.labTun.Name = "labTun";
            this.labTun.Size = new System.Drawing.Size(57, 39);
            this.labTun.TabIndex = 1;
            this.labTun.Text = "00";
            this.labTun.Click += new System.EventHandler(this.label2_Click);
            // 
            // labP
            // 
            this.labP.AutoSize = true;
            this.labP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labP.ForeColor = System.Drawing.Color.Black;
            this.labP.Location = new System.Drawing.Point(45, 66);
            this.labP.Name = "labP";
            this.labP.Size = new System.Drawing.Size(57, 39);
            this.labP.TabIndex = 0;
            this.labP.Text = "00";
            this.labP.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Sek);
            this.groupBox2.Controls.Add(this.Min);
            this.groupBox2.Controls.Add(this.Tun);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(13, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seaded";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Sekundid";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Minutid";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tunnid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Alusta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(243, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 48);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valige kuupäev ning täpne aeg\r\nning aktiveerige taimer vajutades \r\nnuppu \"Alusta\"" +
    "";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Sek
            // 
            this.Sek.Location = new System.Drawing.Point(133, 97);
            this.Sek.Name = "Sek";
            this.Sek.Size = new System.Drawing.Size(100, 20);
            this.Sek.TabIndex = 3;
            this.Sek.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(133, 71);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(100, 20);
            this.Min.TabIndex = 2;
            // 
            // Tun
            // 
            this.Tun.Location = new System.Drawing.Point(133, 45);
            this.Tun.Name = "Tun";
            this.Tun.Size = new System.Drawing.Size(100, 20);
            this.Tun.TabIndex = 1;
            this.Tun.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ul1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ul1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSek;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labTun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Sek;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.TextBox Tun;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

