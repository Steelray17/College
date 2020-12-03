using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKadet_Click(object sender, EventArgs e)
        {
            Form formKadet = new FormKadet();
            formKadet.Show();
        }

        private void buttonSpec_Click(object sender, EventArgs e)
        {
            Form formSpec = new FormSpec();
            formSpec.Show();
        }

        private void buttonListKad_Click(object sender, EventArgs e)
        {
            Form formList = new FormList();
            formList.Show();
        }
    }
}
