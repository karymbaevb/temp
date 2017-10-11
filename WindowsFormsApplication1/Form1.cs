using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parserDecimal.Parser;
using info.lundin.math;
using System.Threading;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            check_form();
            clear_form();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (funcBox.Text != "" || aBox.Text != "" || bBox.Text != "" || tolBox.Text != "" || iterBox.Text != "" || max_timeBox.Text != "")
            {
               
               try
                {
                  time_pogreshnost();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            { 
                MessageBox.Show("Некоторые поля оказались пустыми!");
            } 
        }
        public void time_pogreshnost() 
        {
            progressBar1.Visible = true;
            System.Threading.Thread.Sleep(4);
            double ms = check_form();
            double time_sec = 1;
            if (ms < 100)
            {
                double average_time = 0;
                double sum_time = 0;
               

                for (int i = 0; i < 40; i++)
                {
                    ms = goldenSearchMethod();
                    sum_time = sum_time + ms;
                }
                average_time = sum_time / 40;
                time_sec = average_time / 1000F;

              timeLabOut.Text = Convert.ToString(time_sec);
            }
            else
            {
               
                time_sec = ms / 100F;
                int time_sec_int = Convert.ToInt32(time_sec);
                double time_sec_double = time_sec_int / 10F;
                
               timeLabOut.Text =  Convert.ToString(time_sec_double);
            }
        }
        public double check_form()
        {
            misBox.Text = "";
            misBox2.Text = "";
            panel1.Enabled = false;

            int ms = 0;
            
                int i = 0;
                while (i <= 100)
                {
                    progressBar1.Value = i;
                    i = i + 1;
                    System.Threading.Thread.Sleep(2);
                } 

               ms = goldenSearchMethod();
               return ms;
        }

        public double convertToMs(double time_sec) 
        {
            double time_ms=0;
            time_ms = time_sec * 1000; 
            return time_ms;
        }
        public double goldenSearchMethod()
        {
            decimal a = 0;
            decimal b = 0;
            decimal tol = 0;
            decimal y1 = 0;
            decimal y2 = 0;
            decimal x1 = 0;
            decimal x2 = 0;
            double max_time_sec = Convert.ToDouble(max_timeBox.Text);
            string function = funcBox.Text;
            double tolString = 0;
            int k_max, k = 0;
            bool flag = true;
            int time = 0;
            double max_time_ms = convertToMs(max_time_sec);
            Computer computer = new Computer();
            ExpressionParser parser = new ExpressionParser();

            a = decimal.Parse(aBox.Text);
            b = decimal.Parse(bBox.Text);
            tolString = parser.Parse(tolBox.Text);
            tol = Convert.ToDecimal(tolString);
            k_max = int.Parse(iterBox.Text);

            double r_double = (Math.Pow(5, 0.5) - 1) / 2;
            decimal r_decimal = Convert.ToDecimal(r_double);

            progressBar1.Visible = true;
            k = 1;

            Stopwatch timeMax = new Stopwatch();

            Stopwatch watch = new Stopwatch();
            watch.Reset();


            x1 = a + (1 - r_decimal) * (b - a);
            y1 = Convert.ToDecimal(computer.Compute(function, x1));
            x2 = a + r_decimal * (b - a);
            y2 = Convert.ToDecimal(computer.Compute(function, x2));
            timeMax.Start();
            watch.Start();
            do
            {
                if (y1 > y2)
                {
                    a = x1;
                    x1 = x2;
                    y1 = y2;
                    x2 = a + r_decimal * (b - a);
                    y2 = Convert.ToDecimal(computer.Compute(function, x2));
                    k++;
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    y2 = y1;
                    x1 = a + (1 - r_decimal) * (b - a);
                    y1 = Convert.ToDecimal(computer.Compute(function, x1));
                    k++;
                }

                time = Convert.ToInt32(timeMax.ElapsedMilliseconds);

                if (time >= max_time_ms) { flag = false; }

            } while (k < k_max && (b - a) * 1 > (tol) * 1 && flag != false);
            watch.Stop();

            double ms = Convert.ToDouble(watch.ElapsedMilliseconds);

           // timeLabOut.Text = time;
            xLabOut.Text = Convert.ToString(x1);
            funcLabOut.Text = Convert.ToString(y1);
            iterLabOut.Text = Convert.ToString(k);
            tolString = Math.Abs(Convert.ToDouble(b - a));
            tolLabOut.Text = String.Format("{0:E0}", tolString);

            if (flag == false && Math.Abs(Convert.ToDouble(b - a)) > Convert.ToDouble(tol)) { misBox2.Text = "Для данного решения не хватает времени!"; panel1.Enabled = true; }

            if (k == k_max && Math.Abs(Convert.ToDouble(b - a)) > Convert.ToDouble(tol)) { misBox.Text = "Для данного решения не хватает итераций!"; panel1.Enabled = true; }
            progressBar1.Visible = false;
            return ms;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear_form();
        }
        public void clear_form() 
        {
            xLabOut.Text = "";
            funcLabOut.Text = "";
            iterLabOut.Text = "";
            tolLabOut.Text = "";
            timeLabOut.Text = "";
            progressBar1.Visible = false;
            misBox.Text = "";
            misBox2.Text = "";
            panel1.Enabled = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
