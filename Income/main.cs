using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

            Monthname.Text = Login.Usershow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Dodajmecz Obj = new Dodajmecz();
            Obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WyświetlMecze Obj = new WyświetlMecze();
            Obj.Show();
        }

        private void Monthname_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raport Obj = new Raport();
            Obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }
    }
}
