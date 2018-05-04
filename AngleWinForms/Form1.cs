using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleWinForms;

namespace AngleWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time = DateTime.Parse(maskedTextBox1.Text);

                String.Format("{0:HH:mm}", time);

                int angle = Utilities.GetAngle(Utilities.HoursToZeroAngle(time.Hour), Utilities.MinutesToZeroAngle(time.Minute));
                label1.Text = $"{angle.ToString()}° / {(360 - angle).ToString()}°";
            }
            catch
            {
                label1.Text = "";
                MessageBox.Show("Wprowdź prawidłową godzinę");
            }                    
        }    
        
    }
}
