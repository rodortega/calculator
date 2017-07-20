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
    public partial class form1 : MaterialForm
    {
        public form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightBlue200, TextShade.WHITE);

        }


        private void login_Click(object sender, EventArgs e)
        {
            var system_username = "admin";
            var system_password = "admin";

            if (username.Text == system_username && password.Text == system_password)
            {
                this.Hide();
                var calculatorForm = new form2();
                calculatorForm.Show();
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
