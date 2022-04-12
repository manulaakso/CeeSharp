using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;
using MySql.Data.MySqlClient;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        YHDISTA yhteys = new YHDISTA();
        public Form1()
        {
            InitializeComponent();
        }

        private void cryptaaBT_Click(object sender, EventArgs e)
        {
            String salattu = eCryptography.Encrypt(salasanaTB.Text);
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO salasana(salasana) VALUES (@ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                MessageBox.Show("Salasana cryptattu ja viety tietokantaan");
                salasanaTB.Text = "";
            }
            else
            {
                yhteys.suljeYhteys();
            }
        }

        private void salasanaBT_Click(object sender, EventArgs e)
        {
            String salasana = eCryptography.Decrypt(cryptattuTB.Text);
            MessageBox.Show("Salasanasi on " + salasana);
        }
    }
}
