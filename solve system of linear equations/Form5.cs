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
    public partial class Msg : Form
    {
        public String Title;
        public Msg()
        {
            InitializeComponent();
        }

        private void Msg_Load(object sender, EventArgs e)
        {
            title.Text = Title;
        }
    }
}
