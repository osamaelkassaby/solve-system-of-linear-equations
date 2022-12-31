namespace solve_system_of_linear_equations
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.solve = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.z_lbl = new System.Windows.Forms.Label();
            this.y_lbl = new System.Windows.Forms.Label();
            this.x_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.TextBox();
            this.a3 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.c4 = new System.Windows.Forms.TextBox();
            this.c3 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.we = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.solve.FlatAppearance.BorderSize = 2;
            this.solve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.solve.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.solve.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.solve.Location = new System.Drawing.Point(557, 357);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(100, 39);
            this.solve.TabIndex = 3;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.z_lbl);
            this.panel4.Controls.Add(this.y_lbl);
            this.panel4.Controls.Add(this.x_lbl);
            this.panel4.Location = new System.Drawing.Point(264, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 66);
            this.panel4.TabIndex = 4;
            // 
            // z_lbl
            // 
            this.z_lbl.AutoSize = true;
            this.z_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.z_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.z_lbl.Location = new System.Drawing.Point(327, 15);
            this.z_lbl.Name = "z_lbl";
            this.z_lbl.Size = new System.Drawing.Size(47, 30);
            this.z_lbl.TabIndex = 2;
            this.z_lbl.Text = "Z =";
            // 
            // y_lbl
            // 
            this.y_lbl.AutoSize = true;
            this.y_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.y_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.y_lbl.Location = new System.Drawing.Point(187, 15);
            this.y_lbl.Name = "y_lbl";
            this.y_lbl.Size = new System.Drawing.Size(53, 30);
            this.y_lbl.TabIndex = 1;
            this.y_lbl.Text = "Y = ";
            // 
            // x_lbl
            // 
            this.x_lbl.AutoSize = true;
            this.x_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.x_lbl.Location = new System.Drawing.Point(41, 15);
            this.x_lbl.Name = "x_lbl";
            this.x_lbl.Size = new System.Drawing.Size(54, 30);
            this.x_lbl.TabIndex = 0;
            this.x_lbl.Text = "X = ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 38);
            this.panel5.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::solve_system_of_linear_equations.Properties.Resources.cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.button1.Location = new System.Drawing.Point(880, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 27);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(178, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "About";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(94, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Video";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Website";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.a4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.a4.Location = new System.Drawing.Point(557, 146);
            this.a4.MaxLength = 3;
            this.a4.Multiline = true;
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(35, 26);
            this.a4.TabIndex = 14;
            this.a4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.a3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a3.ForeColor = System.Drawing.Color.White;
            this.a3.Location = new System.Drawing.Point(470, 145);
            this.a3.MaxLength = 3;
            this.a3.Multiline = true;
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(35, 26);
            this.a3.TabIndex = 13;
            this.a3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.a2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.a2.Location = new System.Drawing.Point(389, 146);
            this.a2.MaxLength = 3;
            this.a2.Multiline = true;
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(35, 26);
            this.a2.TabIndex = 12;
            this.a2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.a1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a1.ForeColor = System.Drawing.Color.White;
            this.a1.Location = new System.Drawing.Point(315, 146);
            this.a1.MaxLength = 3;
            this.a1.Multiline = true;
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(35, 26);
            this.a1.TabIndex = 8;
            this.a1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.b4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b4.Location = new System.Drawing.Point(557, 206);
            this.b4.MaxLength = 3;
            this.b4.Multiline = true;
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(35, 26);
            this.b4.TabIndex = 22;
            this.b4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b4.TextChanged += new System.EventHandler(this.b4_TextChanged);
            this.b4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.b3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.ForeColor = System.Drawing.Color.White;
            this.b3.Location = new System.Drawing.Point(470, 206);
            this.b3.MaxLength = 3;
            this.b3.Multiline = true;
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(35, 26);
            this.b3.TabIndex = 21;
            this.b3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.b2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b2.Location = new System.Drawing.Point(389, 206);
            this.b2.MaxLength = 3;
            this.b2.Multiline = true;
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(35, 26);
            this.b2.TabIndex = 20;
            this.b2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.b1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(315, 207);
            this.b1.MaxLength = 3;
            this.b1.Multiline = true;
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(35, 26);
            this.b1.TabIndex = 16;
            this.b1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.c4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c4.Location = new System.Drawing.Point(558, 270);
            this.c4.MaxLength = 3;
            this.c4.Multiline = true;
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(35, 26);
            this.c4.TabIndex = 30;
            this.c4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c4.TextChanged += new System.EventHandler(this.c4_TextChanged);
            this.c4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.c3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c3.ForeColor = System.Drawing.Color.White;
            this.c3.Location = new System.Drawing.Point(470, 269);
            this.c3.MaxLength = 3;
            this.c3.Multiline = true;
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(35, 26);
            this.c3.TabIndex = 29;
            this.c3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.c2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c2.Location = new System.Drawing.Point(389, 270);
            this.c2.MaxLength = 3;
            this.c2.Multiline = true;
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(35, 26);
            this.c2.TabIndex = 28;
            this.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.c1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c1.ForeColor = System.Drawing.Color.White;
            this.c1.Location = new System.Drawing.Point(315, 270);
            this.c1.MaxLength = 3;
            this.c1.Multiline = true;
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(35, 26);
            this.c1.TabIndex = 24;
            this.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(535, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 185);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(653, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 189);
            this.panel2.TabIndex = 32;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(618, 136);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(36, 5);
            this.panel6.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(619, 320);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(36, 5);
            this.panel7.TabIndex = 35;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(264, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(36, 5);
            this.panel8.TabIndex = 36;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(267, 320);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(36, 5);
            this.panel9.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(264, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 189);
            this.panel3.TabIndex = 38;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.clear.FlatAppearance.BorderSize = 2;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Location = new System.Drawing.Point(305, 357);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 39);
            this.clear.TabIndex = 39;
            this.clear.Text = "Cleer";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // we
            // 
            this.we.AutoSize = true;
            this.we.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.we.Location = new System.Drawing.Point(385, 79);
            this.we.Name = "we";
            this.we.Size = new System.Drawing.Size(82, 21);
            this.we.TabIndex = 40;
            this.we.Text = "Welcome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(945, 582);
            this.Controls.Add(this.we);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.solve);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label z_lbl;
        private System.Windows.Forms.Label y_lbl;
        private System.Windows.Forms.Label x_lbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox a4;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox b4;
        private System.Windows.Forms.TextBox b3;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox c4;
        private System.Windows.Forms.TextBox c3;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label we;
    }
}