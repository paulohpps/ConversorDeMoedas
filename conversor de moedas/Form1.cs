using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_de_moedas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            box1.SelectedIndex = 1;
            box2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region REAL
            if (box1.SelectedItem == "Real" && box2.SelectedItem == "Dolar")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 5.42;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Real" && box2.SelectedItem == "Euro")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 6.30;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Real" && box2.SelectedItem == "Bitcoin")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.0000044;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Real" && box2.SelectedItem == "Real")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                valor2.Text = i.ToString();
            }
            #endregion

            #region Dolar
            else if (box1.SelectedItem == "Dolar" && box2.SelectedItem == "Real")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.18;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Dolar" && box2.SelectedItem == "Bitcoin")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.000024;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Dolar" && box2.SelectedItem == "Euro")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 1.16;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Dolar" && box2.SelectedItem == "Dolar")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                valor2.Text = i.ToString();
            }

            #endregion

            #region EURO
            else if (box1.SelectedItem == "Euro" && box2.SelectedItem == "Real")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.16;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Euro" && box2.SelectedItem == "Dolar")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.86;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Euro" && box2.SelectedItem == "Bitcoin")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 35786.53;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Euro" && box2.SelectedItem == "Euro")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                valor2.Text = i.ToString();
            }

            #endregion

            #region Bitcoin
            else if (box1.SelectedItem == "Bitcoin" && box2.SelectedItem == "Euro")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.000028;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Bitcoin" && box2.SelectedItem == "Dolar")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.000024;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Bitcoin" && box2.SelectedItem == "Real")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                i = i * 0.0000044;
                valor2.Text = i.ToString();
            }
            else if (box1.SelectedItem == "Bitcoin" && box2.SelectedItem == "Bitcoin")
            {
                double i;
                i = Convert.ToDouble(valor1.Text);
                valor2.Text = i.ToString();
            }
            #endregion
        }
    }
}
