using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Temp_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);

            //0 being Celsius and 1 being Farenheit.
            int temptype = comboBox1.SelectedIndex;
            int ConvertTo = comboBox2.SelectedIndex;
            
            //Celsius to Farenheit.
            if(temptype == 0 && ConvertTo == 1)
            {
                label1.Text = ConvertToFarenheit(input).ToString();
            }

            //Farenheit to Celsius.
            else if (temptype == 1 && ConvertTo == 0)
            {
                label1.Text = ConvertToCelsius(input).ToString();
            }

            //Shows the notification. Mainly because the user is retarded.
            else
            {
                AreYouRetarded();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Converts to Celsius
        public double ConvertToCelsius(int input)
        {
            double Celsius = (input - 32) * 0.5555555555555555555555555555;
            return Celsius;
        }
        //Convert to Farenheit
        public double ConvertToFarenheit(int input)
        {
            double Farenheit = (input * 1.8) + 32;
            return Farenheit;
        }

        public void AreYouRetarded()
        { 
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Both values cannot be the same";
            popup.ContentText = "Use different temp types.";
            popup.Popup();// show  
        }
    }
}
