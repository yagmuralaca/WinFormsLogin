using System.Data.SqlClient;

namespace WinFormsLogin
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server = YAGMUR; Initial Catalog = dbTaskLogin; Integrated Security = True ");
            string sorgu = "Select * from userInfo where userName=@u_name and userPass=@u_pass";
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@u_name", txt_kadi.Text);
            cmd.Parameters.AddWithValue("@u_pass", txt_sifre.Text);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                OgrenciBilgi f2 = new OgrenciBilgi();
                f2.user_name = txt_kadi.Text;
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanýcý adýnýzý ve þifrenizi konrol ediniz.");
            }
            con.Close();


        }
    }
}