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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.ShowDialog();
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
           signin siignin=new signin();
            siignin.ShowDialog();
            this .Close();
        }
    }
}
