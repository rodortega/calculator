using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace calculator
{
    public partial class form2 : MaterialForm
    {
        // initialize material design theme
        public form2()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);

        }

        // concatinate the button text to input
        private void buttonNumbers_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string num = btn.Text;

            label_input.Text += num;
        }

        // clear input and output
        private void clear(object sender, EventArgs e)
        {
            label_input.Text = "";
            label_output.Text = "0";
        }

        // delete a character from input
        private void delete(object sender, EventArgs e)
        {
           if(label_input.Text.Length >= 1)
            { 
                label_input.Text = label_input.Text.Substring(0, label_input.Text.Length - 1);
            }
        }

        // compute input and display in output
        private void compute(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var v = dt.Compute(label_input.Text, "");

                label_output.Text = v.ToString();
            }

            catch(Exception)
            {
                label_output.Text = "ERROR";
            }

        }

        // close whole application
        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
