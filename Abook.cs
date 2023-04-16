using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design
{
    public partial class Abook : Form
    {
        public Abook()
        {
            InitializeComponent();
        }

        private void Abook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pay success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
