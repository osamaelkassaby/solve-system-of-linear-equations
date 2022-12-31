namespace solve_system_of_linear_equations
{
    partial class Msg
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
            this.ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.Location = new System.Drawing.Point(300, 90);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(88, 32);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(224)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 27);
            this.panel1.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(197, 48);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(324, 25);
            this.title.TabIndex = 3;
            this.title.Text = "May have infinitely many solutions.";
            // 
            // Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ok;
            this.ClientSize = new System.Drawing.Size(692, 134);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Msg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
    }
}