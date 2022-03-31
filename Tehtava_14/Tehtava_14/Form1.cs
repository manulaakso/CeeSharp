using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tehtava_14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users/Okehittaja/source/repos/CeeSharp/paivakirja.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users/Okehittaja/source/repos/CeeSharp/paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
