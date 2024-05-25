using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPROG
{

    public partial class Form1 : Form
    {
    public Form2 displayForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#FF385C");
            Font customFont = new Font("Josefin Sans", 18, FontStyle.Regular);
            foreach (Control control in panel1.Controls)
            {
                control.Font = customFont;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FC7A8E");
            displayForm = new Form2();
            displayForm.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
