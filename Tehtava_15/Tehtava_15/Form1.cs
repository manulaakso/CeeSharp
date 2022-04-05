using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tehtava_15
{
    public partial class SekuntikelloForm : Form
    {
        private Stopwatch stopWatch;
        public SekuntikelloForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
        stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
        stopWatch.Reset();
        }

        private void SekuntikelloForm_Load(object sender, EventArgs e)
        {
        stopWatch = new Stopwatch(); 
        }
    }
}
