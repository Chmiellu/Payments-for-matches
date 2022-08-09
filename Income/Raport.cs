using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income
{
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
            GetTot();
            GetAvg();
            GetSum();
            GetMax();
           
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\tomek\OneDrive\Dokumenty\MatchesDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void GetTot()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Kwota) from MatchesDb where Month='" + Login.Usershow + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sumasuma.Text = dt.Rows[0][0].ToString() + " zł";

            Con.Close();
        }
        private void GetAvg()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Kwota) from MatchesDb where Month='" + Login.Usershow + "'", Con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from MatchesDb where Month='" + Login.Usershow + "'", Con);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            Double Avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
            
            sredniasrednia.Text = Math.Truncate(Avg * 100) / 100 + " zł";
            Con.Close();
        }
        private void GetSum()
        {
            Con.Open();           
            SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from MatchesDb where Month='" + Login.Usershow + "'", Con);            
            DataTable dt1 = new DataTable();        
            sda1.Fill(dt1);         
            sum.Text = dt1.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetSumby()
        {
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(Kwota) from MatchesDb where Month='" + Login.Usershow + "' and Podokręg='"+PodCb.SelectedItem.ToString()+"'", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            sumpod.Text = dt1.Rows[0][0].ToString() + " zł";
            Con.Close();
        }
        private void GetIleby()
        {
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from MatchesDb where Month='" + Login.Usershow + "' and Podokręg='" + PodCb.SelectedItem.ToString() + "' ", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            ilepod.Text = dt1.Rows[0][0].ToString();
            Con.Close();
        }
        private void GetMax()
        {
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Max(Kwota) from MatchesDb where Month='" + Login.Usershow + "'", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            maxi.Text = dt1.Rows[0][0].ToString() + " zł";
            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PodCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSumby();
            GetIleby();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
