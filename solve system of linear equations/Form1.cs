using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solve_system_of_linear_equations
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e )

        {

            panel1.Width += 2;
            label2.Text = panel1.Width/10+20 + "%";

            if (panel1.Width >= 300)
            {
                label1.Text = "Created by osamaelkassaby";
            }
            if(panel1.Width >= 600)
            {
                label1.Text = "Dr. Hamada Nayil";
                Font font = new Font("Segoe UI", 24);

                label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                label1.Location = new System.Drawing.Point(250, 6);
            }
            if(panel1.Width >= 700)
            {
            }
            if (panel1.Width >= 800)
            {
                Form2 frm = new Form2();
                timer1.Stop();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
