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
    public partial class parts : Form
    {
        public parts()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adly adly
                    = new Adly();
            adly.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Nedal nedal = new Nedal();
            nedal.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eyad eyad = new Eyad();
            eyad.Show();
               
            this.Close();
        }
    }
}
