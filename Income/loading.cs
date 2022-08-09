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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            progressBar1.Value= startP;
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();
            }
        }
    }
}
