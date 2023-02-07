using System.Windows.Forms;
using Calculator.Properties;

namespace Calculator
{
    public partial class Form2_Settings : Form
    {
        public Form2_Settings()
        {
            InitializeComponent();
            radioButton1.Checked = Settings.Default.RB1F2;
            radioButton2.Checked = Settings.Default.RB2F2;
            radioButton3.Checked = Settings.Default.RB3F2;
            radioButton4.Checked = Settings.Default.RB4F2;
            radioButton5.Checked = Settings.Default.RB5F2;
            CheckBox1.Checked    = Settings.Default.CB1F2;
            CheckBox2.Checked    = Settings.Default.CB2F2;
            CheckBox3.Checked    = Settings.Default.CB3F2;
            CheckBox4.Checked    = Settings.Default.CB4F2;
            CheckBox5.Checked    = Settings.Default.CB5F2;
        }

        private void Form2_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.RB1F2 = radioButton1.Checked == true ? true : false;
            Settings.Default.RB2F2 = radioButton2.Checked == true ? true : false;
            Settings.Default.RB3F2 = radioButton3.Checked == true ? true : false;
            Settings.Default.RB4F2 = radioButton4.Checked == true ? true : false;
            Settings.Default.RB5F2 = radioButton5.Checked == true ? true : false;
            Settings.Default.CB2F2 = CheckBox2.Checked    == true ? true : false;
            Settings.Default.CB1F2 = CheckBox1.Checked    == true ? true : false;
            Settings.Default.CB3F2 = CheckBox3.Checked    == true ? true : false;
            Settings.Default.CB4F2 = CheckBox4.Checked    == true ? true : false;
            Settings.Default.CB5F2 = CheckBox5.Checked    == true ? true : false;
        }
    }
}
