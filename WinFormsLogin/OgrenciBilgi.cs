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

namespace WinFormsLogin
{
    public partial class OgrenciBilgi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public OgrenciBilgi()
        {
            InitializeComponent();
        }
        public string user_name = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_hsgldn.Text = user_name;
            ogrenciListele();
        }
        void ogrenciListele()
        {
            string sorgu = "Select stFirstName as Ogr_Adi, stLastName as Ogr_Soyadi, stBirthDate as Dogum_Tarihi, stEmail as Email_Adresi From studentInfo";

            con = new SqlConnection("server=YAGMUR; Initial Catalog=dbTaskLogin; Integrated Security=True ");
            da = new SqlDataAdapter(sorgu, con);

            ds = new DataSet();

            con.Open();
            da.Fill(ds, "studentInfo");

            dgw_ogr.DataSource = ds.Tables["studentInfo"];
            con.Close();

        }
    }
}
