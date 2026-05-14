using System.Data;
using System.Data.SqlClient;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=biengese;Initial Catalog=KitapVT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        void listele()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Kitaplar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Turler()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tur", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "Turid";
            comboBox1.ValueMember = "TurAd";
            comboBox1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
            Turler();
        }
    }
}
