using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
namespace solve_system_of_linear_equations
{
    public partial class Form2 : Form
    {
        public static int N = 3;
        public static int Eq_X;
        public static int Eq_Y;
        public static int Eq_Z;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            we.Text = "Welcome " +Environment.UserName;
            solve.Visible = false;
            clear.Visible = false;
            x_lbl.Text = "";
            y_lbl.Text = "";
            z_lbl.Text = "";
            
        }

        private void solve_Click(object sender, EventArgs e)
        {




            double[,] mat = {
                    { ToDouble(a1.Text),ToDouble(a2.Text), ToDouble(a3.Text), ToDouble(a4.Text) },
                    {ToDouble(b1.Text),ToDouble(b2.Text), ToDouble(b3.Text), ToDouble(b4.Text)},
                    { ToDouble(c1.Text),ToDouble(c2.Text), ToDouble(c3.Text), ToDouble(c4.Text)} };
           
            gaussianElimination(mat);


           x_lbl.Text = "X = " + Eq_X;
           y_lbl.Text = "Y = " + Eq_Y;
           z_lbl.Text = "Z = " + Eq_Z;
           clear.Visible = true;




        }

        static void gaussianElimination(double[,] mat)
        {

            int singular_flag = forwardElim(mat);

            /* if matrix is singular */
            if (singular_flag != -1)
            {
                Console.WriteLine("Singular Matrix.");

                if (mat[singular_flag, N] != 0) {
                    Eq_X = 0;
                    Eq_Y = 0;
                    Eq_Z = 0;

                    Msg msg = new Msg();
                    msg.Title = "Inconsistent System.";
                    msg.ShowDialog();
                }
                else
                {
                    Eq_X = 0;
                    Eq_Y = 0;
                    Eq_Z = 0;

                    Msg msg = new Msg();
                    msg.Title = "May have infinitely many solutions.";
                    msg.ShowDialog();
                }

                return;
            }

            
            backSub(mat);
        }

        
        static void swap_row(double[,] mat, int i, int j)
        {


            for (int k = 0; k <= N; k++)
            {
                double temp = mat[i, k];
                mat[i, k] = mat[j, k];
                mat[j, k] = temp;
            }
        }

        static void print(double[,] mat)
        {
            for (int i = 0; i < N; i++, Console.WriteLine())
                for (int j = 0; j <= N; j++)
                    Console.Write(mat[i, j]);

            Console.WriteLine();
        }

        static int forwardElim(double[,] mat)
        {
            for (int k = 0; k < N; k++)
            {

                int i_max = k;
                int v_max = (int)mat[i_max, k];

                for (int i = k + 1; i < N; i++)
                {
                    if (Math.Abs(mat[i, k]) > v_max)
                    {
                        v_max = (int)mat[i, k];
                        i_max = i;
                    }

                    
                    if (mat[k, i_max] == 0)
                        return k; 
                    if (i_max != k)
                        swap_row(mat, k, i_max);

                    for (int a = k + 1; a < N; a++)
                    {

                        double f = mat[i, k] / mat[k, k];

                      
                        for (int j = k + 1; j <= N; j++)
                            mat[i, j] -= mat[k, j] * f;

                   
                        mat[i, k] = 0;
                    }
                }
              
            }

           
            return -1;
        }

        static void backSub(double[,] mat)
        {

            double[] x = new double[N];

            for (int i = N - 1; i >= 0; i--)
            {

                x[i] = mat[i, N];

                for (int j = i + 1; j < N; j++)
                {

                    x[i] -= mat[i, j] * x[j];
                }

                
                x[i] = x[i] / mat[i, i];
            }

          
            for (int i = 0; i < N; i++)
            {
                    Eq_X = (int)x[0];
                    Eq_Y = (int)x[1];
                    Eq_Z = (int)x[2];
                

            }
        }



        public  double ToDouble(String textBox)
        {
           
                int num = Int32.Parse(textBox.ToString());
                double cnv = Convert.ToDouble(num);
            
                return cnv;
            
            
           
        }

        private void label13_Click(object sender, EventArgs e)
        {
            OpenUrl("http://osamaelkassaby.com");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form3 form3  = new Form3();
            form3.ShowDialog();
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void b4_TextChanged(object sender, EventArgs e)
        {

        }

        private void c4_TextChanged(object sender, EventArgs e)
        {
            if (a1.Text.Length >= 1 && c4.Text.Length >= 1 && c1.Text.Length >= 1 && b1.Text.Length >= 1 && b4.Text.Length >= 1)
            {
                solve.Visible = true;
            }
            else
            {
                solve.Visible = false;

            }
        }

        private void a1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
               
                if(e.KeyChar != '-')
                {
                    Msg msg = new Msg();
                    msg.Title = Environment.UserName+" The Field Can't be (" + e.KeyChar + ") Numbers Only .";
                    msg.ShowDialog();

                    e.Handled = true;
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
           


            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            c4.Text = "";

            x_lbl.Text = "";
            y_lbl.Text = "";
            z_lbl.Text = "";
            solve.Visible = false;
            clear.Visible = false;
        }
    }
}
