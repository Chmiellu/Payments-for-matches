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
    public partial class Dodajmecz : Form
    {
        public Dodajmecz()
        {
            InitializeComponent();
        }

        public void Dodajmecz_Load(object sender, EventArgs e)
        {
            Month.Text = Login.Usershow;
        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\tomek\OneDrive\Dokumenty\MatchesDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void Clear()
        {
            KlasaCb.SelectedIndex = 0;  
            PodokregCb.SelectedIndex = 0;
            Kwota.Text = "";
           
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            if(KlasaCb.SelectedIndex==-1 || PodokregCb.SelectedIndex==-1  || Kwota.Text=="")
            {
                MessageBox.Show("Brakuje danych");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into MatchesDb (Klasa,Podokręg,Month,Kwota) values (@K,@P,@M,@KW)", Con);
                cmd.Parameters.AddWithValue("@K", KlasaCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@P", PodokregCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@M", Month.Text);
                cmd.Parameters.AddWithValue("@KW", Kwota.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodano mecz"); 
                Con.Close();  
                Clear(); 
            }

        }

        private void KlasaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from KwotyDb where Klasa='"+KlasaCb.Text+"'", Con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string Id = dr.GetInt32(0).ToString();
                string Klasa = dr.GetString(1);
                string Kwotaa = dr.GetString(2);

                Kwota.Text = Kwotaa;
            }
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Month_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
