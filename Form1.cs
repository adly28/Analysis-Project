namespace design
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup signup = new signup();   
            signup.ShowDialog();
            this.Close();
        }
    }
}