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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\tomek\OneDrive\Dokumenty\MatchesDb.mdf;Integrated Security = True; Connect Timeout = 30");
        public static string Usershow;
        private void LoginB_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where Month='"+User.Text+"' and Password='"+Password.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                Usershow = User.Text;
                main Obj = new main();
                
                Obj.Show();
                this.Hide();
                Con.Close();
            }else
            {
                MessageBox.Show("Zły login lub hasło");
            }
            Con.Close();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
