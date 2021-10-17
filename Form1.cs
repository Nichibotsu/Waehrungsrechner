using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsrechner
{
    public partial class Form1 : Form
    {
        public string eingabe;
        public double ergebnis1;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "-Auswählen-")
            {
                MessageBox.Show("Eingabe Währung auswählen");
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Wert bitte eingeben");
            }
            else if (comboBox2.Text == "-Auswählen-")
            {
                MessageBox.Show("Ausgabe Währung wählen");
            }
            else
            {
                double a = Convert.ToDouble(textBox1.Text);
                eingabe = comboBox1.Text;
                string ausgabe = comboBox2.Text;
                a=Basiswert(a);
                ergebnis1 = Rechner.Umwandlung(a, ausgabe);
                label2.Text = "Ausgabe: "+Convert.ToString(ergebnis1);
                
            }
        }
        private double Basiswert(double a)
        {
            double result = 0;
            double dollarg = 1.1719; 
            double pfundg = 0.857;
            if ( eingabe== "Euro")
                result = a;
            else if (eingabe == "Dollar")
                result = a / dollarg;
            else if (eingabe == "Pfund")
                result = a / pfundg;
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
