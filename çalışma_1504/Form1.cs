using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çalışma_1504
{
    public partial class Form1 : Form
    {
        string  baglantımetım = "Server=localhost;Database= film_arsiv;Uid=root;Pwd='';";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantımetım))
            {
                baglan.Open();//VERİTAN  BALTISIN AÇ
                string sorgu = "SELECT * FROM FİLMLER;";//SORGUMUZU

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);    
               DataTable dt = new DataTable();
                da.Fill(dt);
                dgwfılmler.DataSource = dt;


            }
        }

        private void bntelestiri_Click(object sender, EventArgs e)
        {

        }
    }
}