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
    public partial class WyświetlMecze : Form
    {
        public WyświetlMecze()
        {
            InitializeComponent();
            ShowMatches();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\tomek\OneDrive\Dokumenty\MatchesDb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void ShowMatches()
        {
            Con.Open();
            string Query = "select Klasa,Podokręg,Kwota from MatchesDb where Month='" + Login.Usershow + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Mecze.DataSource=ds.Tables[0];
            Con.Close();
        }
        private void Fillbycat()
        {
            Con.Open();
            string Query = "select Klasa,Podokręg,Kwota from MatchesDb where Month='" + Login.Usershow + "' and Podokręg='"+PodCb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Mecze.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mecze_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mecze_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WyświetlMecze_Load(object sender, EventArgs e)
        {
            Mecze.EnableHeadersVisualStyles = false;
            Mecze.ColumnHeadersDefaultCellStyle.BackColor= Color.IndianRed;
            Mecze.ColumnHeadersDefaultCellStyle.ForeColor= Color.White; 
            Mecze.DefaultCellStyle.BackColor= Color.White;
            Mecze.DefaultCellStyle.Font = new Font("tahoma", 13);

            Mecze.ColumnHeadersDefaultCellStyle.Font=new Font("tahoma",15,FontStyle.Bold);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowMatches();
        }

        private void PodCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Fillbycat();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
